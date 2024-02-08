namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new();
        Personnage dragon = new Personnage();

        public Form1()
        {
            InitializeComponent();
            joueur.PointDevie = 10;
            joueur.PointDePuissance = 1;

            dragon.PointDevie = 30;
            dragon.PointDePuissance = 3;

        }
        private void ActualiserLabels()
        {
            lbl_pointsVieJoueur.Text = " Vie du joueur : " + joueur.PointDevie.ToString();
            lbl_pointsVieDragon.Text = " Vie du dragon : " + dragon.PointDevie.ToString();
            lbl_puissanceAttaqueJoueur.Text = " Attaque du joueur : " + joueur.PointDePuissance.ToString();
            lbl_puissanceAttaqueDragon.Text = " Attaque du dragon : " + dragon.PointDePuissance.ToString();

        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.PointDevie -= joueur.PointDePuissance; 
            ActualiserLabels();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            ActualiserLabels();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            ActualiserLabels();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserLabels();
        }
    }
}