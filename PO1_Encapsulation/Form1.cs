namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new Personnage();
        Personnage dragon = new Personnage();
        public Form1()
        {
            InitializeComponent();
            joueur.PointDeVie = 10;
            dragon.PointDeVie = joueur.PointDeVie * 3;
            joueur.PointsDePuissance = 1;
            dragon.PointsDePuissance = joueur.PointsDePuissance * 3;

        }

        private void ActualiserLabel()
        {
            lbl_pointsVieJoueur.Text = "Points de vie : " + joueur.PointDeVie.ToString();
            lbl_pointsVieDragon.Text = "Points de vie : " + dragon.PointDeVie.ToString();
            lbl_puissanceAttaqueJoueur.Text = "Puissance d'attaque :" + joueur.PointsDePuissance.ToString();
            lbl_puissanceAttaqueDragon.Text = "Puissance d'attaque :" + dragon.PointsDePuissance.ToString();
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.PointDeVie -= joueur.PointsDePuissance;
            TourDragon();
            ActualiserLabel();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            joueur.PointDeVie += 5;
            TourDragon();
            if ( joueur.PointDeVie > 10 )
            {
                joueur.PointDeVie = 10;
            }
            ActualiserLabel();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            TourDragon();
            ActualiserLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            joueur.PointsDePuissance += 1;
            ActualiserLabel();
        }

        private void TourDragon()
        {
            joueur.PointDeVie -= dragon.PointsDePuissance;
        }
    }
}