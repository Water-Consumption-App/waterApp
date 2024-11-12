using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace waterApp
{
    public partial class formGame : Form
    {
        public formGame()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove bordas
        }


        private int vidaAgua = 50;
        private int vidaConsumo = 100;



        public class QuizQuestion
        {
            public string QuestionText { get; set; }
            public List<string> Options { get; set; }
            public int CorrectAnswerIndex { get; set; }
        }

        private List<QuizQuestion> questions;
        private int currentQuestionIndex = 0;

        private void InitializeQuestions()
        {
            questions = new List<QuizQuestion>
            {
                    new QuizQuestion
    {
        QuestionText = "Qual é a principal fonte de água?",
        Options = new List<string> { "Rio", "Mar", "Lago", "Subterrânea" },
        CorrectAnswerIndex = 3
    },
    new QuizQuestion
    {
        QuestionText = "Qual a porcentagem aproximada da água doce disponível no planeta?",
        Options = new List<string> { "Menos de 1%", "Entre 5% e 10%", "Mais de 50%", "Cerca de 30%" },
        CorrectAnswerIndex = 0
    },
    new QuizQuestion
    {
        QuestionText = "Quais são os principais fatores que contribuem para a escassez de água doce em algumas regiões do mundo?",
        Options = new List<string> { "Crescimento populacional", "Mudanças climáticas", "Poluição", "Todas as alternativas" },
        CorrectAnswerIndex = 3
    },
    new QuizQuestion
    {
        QuestionText = "Qual o principal uso da água doce no mundo?",
        Options = new List<string> { "Consumo humano", "Agricultura", "Indústria", "Geração de energia" },
        CorrectAnswerIndex = 1 // Ajuste o índice conforme a resposta correta
    },
    new QuizQuestion
    {
        QuestionText = "Qual a principal causa da poluição da água doce?",
        Options = new List<string> { "Resíduos industriais", "Agrotóxicos", "Esgoto doméstico", "Todas as alternativas" },
        CorrectAnswerIndex = 3
    },
    new QuizQuestion
    {
        QuestionText = "Qual região brasileira enfrenta os maiores desafios relacionados à escassez de água?",
        Options = new List<string> { "Nordeste", "Sul", "Sudeste", "Norte" },
        CorrectAnswerIndex = 0
    },
    new QuizQuestion
    {
        QuestionText = "Qual o principal setor consumidor de água no Brasil?",
        Options = new List<string> { "Industrial", "Doméstico", "Agrícola", "Energia" },
        CorrectAnswerIndex = 2 // Ajuste o índice conforme a resposta correta
    },
    new QuizQuestion
    {
        QuestionText = "Quais as principais consequências da má gestão dos recursos hídricos no Brasil?",
        Options = new List<string> { "Secas prolongadas", "Inundações", "Conflitos por água", "Todas as alternativas" },
        CorrectAnswerIndex = 3
    },
    new QuizQuestion
    {
        QuestionText = "Quais medidas podem ser adotadas para reduzir o consumo de água em casa?",
        Options = new List<string> { "Reutilizar a água da chuva", "Consertar vazamentos", "Diminuir o tempo de banho", "Todas as alternativas" },
        CorrectAnswerIndex = 3
    },
    new QuizQuestion
    {
        QuestionText = "Como as mudanças climáticas podem afetar a disponibilidade de água doce no futuro?",
        Options = new List<string> { "Aumentando a oferta", "Diminuindo a oferta", "Não haverá impacto", "Aumentando a qualidade" },
        CorrectAnswerIndex = 1
    },
    new QuizQuestion
    {
        QuestionText = "Qual a importância da educação ambiental para a preservação dos recursos hídricos?",
        Options = new List<string> { "Baixa", "Média", "Alta", "Fundamental" },
        CorrectAnswerIndex = 3
    },
    new QuizQuestion
    {
        QuestionText = "Quais tecnologias podem auxiliar na gestão eficiente dos recursos hídricos?",
        Options = new List<string> { "Dessalinização da água do mar", "Sistemas de irrigação eficientes", "Tratamento de água", "Todas as alternativas" },
        CorrectAnswerIndex = 3
    },
    new QuizQuestion
    {
        QuestionText = "O que é a pegada hídrica e como ela pode ser calculada?",
        Options = new List<string> { "É a quantidade de água doce utilizada direta e indiretamente por uma pessoa ou produto.", "É a medida da qualidade da água.", "É a distância que a água percorre até chegar ao consumidor.", "É a quantidade de água evaporada durante o processo de produção." },
        CorrectAnswerIndex = 0
    },
    new QuizQuestion
    {
        QuestionText = "Qual a diferença entre água virtual e água real?",
        Options = new List<string> { "Água virtual é a água utilizada na produção de bens e serviços, enquanto água real é a água que consumimos diretamente.", "Não há diferença entre água virtual e água real.", "Água virtual é a água da chuva, enquanto água real é a água dos rios.", "Água virtual é a água do mar, enquanto água real é a água doce." },
        CorrectAnswerIndex = 0
    },
    new QuizQuestion
    {
        QuestionText = "Quais os principais desafios para a implementação de políticas públicas de gestão dos recursos hídricos?",
        Options = new List<string> { "Falta de planejamento", "Conflitos de interesses", "Resistência à mudança", "Todas as alternativas" },
        CorrectAnswerIndex = 3
    },
    new QuizQuestion
    {
        QuestionText = "Qual o papel das empresas na gestão da água?",
        Options = new List<string> { "Reduzir o consumo de água, tratar os efluentes, investir em tecnologias sustentáveis", "Apenas produzir bens e serviços", "Não possuem responsabilidade sobre a gestão da água", "Somente as empresas do setor de saneamento devem se preocupar com a água." },
        CorrectAnswerIndex = 0
    }
            };
        }

        private void DisplayQuestion()
        {
            var question = questions[currentQuestionIndex];
            label5.Text = question.QuestionText;
            button1.Text = question.Options[0];
            button2.Text = question.Options[1];
            button3.Text = question.Options[2];
            button4.Text = question.Options[3];

            AtualizarVida(); // Atualizar a vida sempre que uma nova pergunta é exibida
        }

        private void formGame_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            InitializeQuestions();
            AtualizarVida(); // Exibir vidas no início
            DisplayQuestion();

            // Configurando tags e associando os botões ao evento de clique
            button1.Tag = 0;
            button1.Click += AnswerButton_Click;

            button2.Tag = 1;
            button2.Click += AnswerButton_Click;

            button3.Tag = 2;
            button3.Click += AnswerButton_Click;

            button4.Tag = 3;
            button4.Click += AnswerButton_Click;

            // Definindo o valor máximo das barras
            progressBar1.Maximum = vidaAgua;
            progressBar2.Maximum = vidaConsumo;
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            Button selectedButton = (Button)sender;
            int selectedAnswerIndex = int.Parse(selectedButton.Tag.ToString());

            if (selectedAnswerIndex == questions[currentQuestionIndex].CorrectAnswerIndex)
            {
                MessageBox.Show("Correto!");
                vidaConsumo -= 20; // Diminui a vida do consumo ao acertar
            }
            else
            {
                MessageBox.Show("Incorreto!");
                vidaAgua -= 10; // Diminui a vida da água ao errar
            }

            AtualizarVida(); // Atualiza os labels com os novos valores

            // Verificar se a vida da água ou do consumo chegou a zero
            if (vidaAgua <= 0)
            {
                MessageBox.Show("Infelizmente o Dr. Consumo ganhou e água do mundo acabou! Jogo encerrado.");
                ResetarJogo();
                return;
            }
            else if (vidaConsumo <= 0)
            {
                MessageBox.Show("Parabéns! Você venceu o Dr. Consumo, agora a Terra está mais saúdavel.");
                ResetarJogo();
                return;
            }

            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("Quiz completo!");
                ResetarJogo();
            }
        }

        private void AtualizarVida()
        {
            //label3.Text = $"Vida Água: {vidaAgua}";
            //label4.Text = $"Vida Consumo: {vidaConsumo}";
            progressBar1.Value = vidaAgua;
            progressBar2.Value = vidaConsumo;
        }

        private void ResetarJogo()
        {
            currentQuestionIndex = 0;
            vidaAgua = 50;
            vidaConsumo = 100;
            AtualizarVida();
            DisplayQuestion();
        }
    }
}
