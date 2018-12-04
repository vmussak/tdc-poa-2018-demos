using DemoTDCPadroes.Models;
using DemoTDCPadroes.Reconhecimento;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DemoTDCPadroes
{
    public partial class ReconhecimentoForm : Form
    {
        string _basePath = @"C:\Users\Vinicius Mussak\Desktop\DemoTDCPadroes\DemoTDCPadroes\Imagens\";
        const string trainingApiKey = "7c0e4f203da244f89067f4d6dc5aca18";
        const string predictionApiKey = "cd3d1c14247a4138af9f2b1e9695e0a3";
        ReconhecedorDePadroes _reconhecedorDePadroes;
        ComparadorDePadroes _comparadorDePadroes;
        Iteration iteration;
        Project _project;

        public ReconhecimentoForm()
        {
            _reconhecedorDePadroes = new ReconhecedorDePadroes(trainingApiKey);
            _comparadorDePadroes = new ComparadorDePadroes(predictionApiKey);
            InitializeComponent();
        }

        private void btnNovoProjeto_Click(object sender, EventArgs e)
        {
            IList<Domain> domains = _reconhecedorDePadroes.BuscarDominios();

            labelDominios.Text = "";
            foreach (var item in domains)
                labelDominios.Text += $"{item.Exportable} | {item.Id} | {item.Name}\n";

            Domain generalDomain = domains.First(d => d.Name == "General" && d.Exportable == false);

            _reconhecedorDePadroes.ExcluirProjetos();

            _project = _reconhecedorDePadroes.CriarProjeto($"TDC_DEMO",
                                                        "Demo de reconhecimento de padrões :D",
                                                        generalDomain.Id);

            labelProjeto.Text = _project.Name + "\n" + _project.Id;

        }

        private void btnTagCerveja_Click(object sender, EventArgs e)
        {
            labelTag.Text = "cerveja";
            labelDominios.Text = "";
            pictureBox1.Visible = true;
            Tag tagCerveja = _reconhecedorDePadroes.CriarTag(_project.Id, "cerveja", "Lata de cerveja");
            UploadDasImagens(tagCerveja);
        }

        private void btnTagChima_Click(object sender, EventArgs e)
        {
            labelTag.Text = "chimarrao";
            Tag tagCuiaChimarrao = _reconhecedorDePadroes.CriarTag(_project.Id, "chimarrao", "Cuia com chimarrao");
            UploadDasImagens(tagCuiaChimarrao);
        }

        private void btnTreinar_Click(object sender, EventArgs e)
        {
            labelTag.Text = "";
            labelStatus.Text = "Treinando";
            iteration = _reconhecedorDePadroes.TreinarProjeto(_project.Id);

            while (iteration.Status == "Training")
            {
                labelStatus.Text += ".";
                iteration = _reconhecedorDePadroes.BuscarIteracao(_project.Id, iteration.Id);
                System.Threading.Thread.Sleep(2000);
            }

            labelStatus.Text = "FOI :)";
        }

        void UploadDasImagens(Tag tag)
        {
            var tagIds = new List<string> { tag.Id.ToString() };
            foreach (var imagePath in Directory.GetFiles($"{_basePath}{tag.Name}"))
            {
                using (var imageStream = new FileStream(imagePath, FileMode.Open))
                {
                    _reconhecedorDePadroes.CriarImagem(_project.Id, imageStream, tagIds);
                }

                SetPicture(imagePath);
            }
        }

        private void SetPicture(string img)
        {
            if (pictureBox1.InvokeRequired)
            {
                pictureBox1.Invoke(new MethodInvoker(
                delegate ()
                {
                    pictureBox1.Load(img);
                }));
            }
            else
            {
                pictureBox1.Load(img);
            }
            pictureBox1.Refresh();
            System.Threading.Thread.Sleep(2000);
        }

        private void btnReconhecerCerveja_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Jpeg files | *.jpg";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                string path = dialog.FileName;
                
                ResultadoDoReconhecimento resultado;

                using (var imageStream = new FileStream(path, FileMode.Open))
                {
                    resultado = _comparadorDePadroes.ReconhecerImagem(_project.Id, iteration.Id, imageStream);
                }

                pictureBox1.Load(path);
                pictureBox1.Refresh();

                labelResultado.Text = "";
                foreach (var tag in resultado.Predictions)
                    labelResultado.Text += $"{tag.Tag}: {tag.Probability:P2}\n";
            }
        }
    }
}
