using TwentyE;
using static TwentyE.Properties.Resources;

namespace Periyodik_Tablo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        readonly string metaller = "Metaller";
        readonly string ametaller = "Ametaller";
        readonly string yariMetaller = "Yar� Metaller";
        readonly string soyGazlar = "Soy Gazlar (Ametaller)";
        readonly string alkaliMetaller = "Alkali Metaller (Metaller)";
        readonly string toprakAlkaliMetaller = "Toprak Alkali Metaller (Metaller)";
        readonly string halojenler = "Halojenler (Ametaller)";
        private int isMBC = 2;
        private int isABC = 2;
        private int isYMBC = 2;
        private Rectangle buttonOriginalRectangle;
        private Rectangle buttonOriginalRectangle1;
        private Rectangle originalFormSize;

        public void VisibilityOff(params Button[] excepts)
        {
            Button[] buttons = { H, He, Li, Be, B, C, N, O, F, Ne, Na, Mg, Al, Si, P, S, Cl, Ar, K, Ca, MB, AB, YMB };

            foreach (Button button in buttons)
            {
                button.Visible = false;
            }

            foreach (Button except in excepts)
            {
                except.Visible = true;
            }
        }
        public void VisibilityOn()
        {
            Button[] buttons = { H, He, Li, Be, B, C, N, O, F, Ne, Na, Mg, Al, Si, P, S, Cl, Ar, K, Ca, MB, AB, YMB };
            foreach (Button button in buttons)
            {
                button.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            buttonOriginalRectangle = new Rectangle(tableLayoutPanel1.Location.X, tableLayoutPanel1.Location.Y, tableLayoutPanel1.Width, tableLayoutPanel1.Height); buttonOriginalRectangle = new Rectangle(tableLayoutPanel1.Location.X, tableLayoutPanel1.Location.Y, tableLayoutPanel1.Width, tableLayoutPanel1.Height);
            buttonOriginalRectangle1 = new Rectangle(tableLayoutPanel2.Location.X, tableLayoutPanel2.Location.Y, tableLayoutPanel2.Width, tableLayoutPanel2.Height);
        }

        public static void KisaYaz(string aciklama, string kullanimAlanlari, int AtomNumarasi, string sinif, string elementIsmi, Image image)
        {
            //MessageBox.Show($"{aciklama}\nKullan�m alanlar� : {kullanimAlanlari}\nAtom Numaras� : {AtomNumarasi}\nProton say�s� : {AtomNumarasi}\nElektron say�s� : {AtomNumarasi}\nBulundu�u S�n�f : {sinif}", elementIsmi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            MyMessageBox.ShowBox(elementIsmi, aciklama, kullanimAlanlari, AtomNumarasi, sinif, image);
        }
        private void H_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Do�adaki en hafif element olan hidrojen; renksiz, kokusuz ve yan�c� bir elementtir.\nKullan�m alanlar� : hidrojen balonlar�n� �i�irme, petrol�n i�lenmesi, amonyak yap�m�, roket yak�tlar�, ya�lar�n doyurulmas�..\nAtom Numaras� : 1\nProton say�s� : 1\nElektron say�s� : 1\nBulundu�u s�n�f : Ametaller", "Hidrojen Elementi (H)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MyMessageBox.ShowBox("Hidrojen (H)", "Do�adaki en hafif element olan hidrojen; renksiz, kokusuz ve yan�c� bir elementtir.", "hidrojen balonlar�n�n�n �i�irilmesi, petrol�n i�lenmesi, amonyak yap�m�, roket yak�tlar�, ya�lar�n doyurulmas�..", 1, ametaller, Hidrojen);
        }

        private void He_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hidrojenden sonra en hafif element olan helyum elementi, renksiz ve kokusuz haldedir.\nKullan�m alanlar� : zeplinler, u�an balonlar..\nAtom Numaras� : 2\nProton say�s� : 2\nElektron say�s� : 2\nBulundu�u s�n�f : Soy Gazlar (Ametaller)", "Helyum Elementi (He)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MyMessageBox.ShowBox("Helyum (He)", "Hidrojenden sonra en hafif element olan helyum elementi, renksiz ve kokusuz haldedir.","zeplinler, u�an balonlar..", 2, soyGazlar, Helyum);
        }

        private void Li_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Lityum, do�ada yo�unlu�u en az olan ve do�ada saf haliyle bulunamayan yumu�ak ve g�m���ms� beyaz bir elementtir.\nKullan�m alanlar� : ila� yap�m�, telefon, tablet, bilgisayar gibi teknolojik aletlerin bataryalar�n�n yap�m�, cam ve seramik.. \nAtom Numaras� : 3\nProton say�s� : 3\nElektron say�s� : 3\nBulundu�u s�n�f : " + alkaliMetaller, "Lityum Elementi (Li)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MyMessageBox.ShowBox("Lityum (Li)", "Lityum, do�ada yo�unlu�u en az olan ve do�ada saf haliyle bulunamayan yumu�ak ve g�m���ms� beyaz bir elementtir.", "ila� yap�m�, telefon, tablet, bilgisayar gibi teknolojik aletlerin bataryalar�n�n yap�m�, cam ve seramik..", 3, alkaliMetaller, Lityum);
        }

        private void Be_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Berilyum, do�ada nadir rastlanan ve �ok az bulunan bir elementtir.\nKullan�m alanlar� : Hava ta��tlar�, uzay ara�lar�, f�zeler ve ileti�im uydular�nda, n�kleer reakt�rlerde yans�t�c� ya da n�tron d�zenleyici..\nAtom Numaras� : 4\nProton say�s� : 4\nElektron say�s� : 4\nBulundu�u s�n�f : " + toprakAlkaliMetaller, "Berilyum (Be)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MyMessageBox.ShowBox("Berilyum (Be)", "Berilyum, do�ada nadir rastlanan ve �ok az bulunan bir elementtir.", "hava ta��tlar�, uzay ara�lar�, f�zeler ve ileti�im uydular�, n�kleer reakt�rlerde yans�t�c� ya da n�tron d�zenleyici..", 4, toprakAlkaliMetaller, Berilyum);
        }

        private void B_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("D�nya'daki bor rezervinin %50'sinden fazlas� T�rkiye'de bulunur.\nKullan�m alanlar� : cam, seramik, deterjan, ila� ve kimya sanayii, yanmay� �nleyici (geciktirici) madde yap�m�, tar�m, metalurji, enerji depolama, arabalar (hava yast�klar�, hidrolik fren vb), su ar�tma, pigment ve kurutucu olarak, n�kleer uygulamalar..\nAtom Numaras�: 5\nProton say�s�: 5\nElektron say�s�: 5\nBulundu�u s�n�f : Yar� Metaller", "Bor (B)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MyMessageBox.ShowBox("Bor (B)", "D�nya'daki bor rezervinin %50'sinden fazlas� T�rkiye'de bulunur.", "cam, seramik, deterjan, ila� ve kimya sanayii, yanmay� �nleyici (geciktirici) madde yap�m�, tar�m, metalurji, enerji depolama, arabalar (hava yast�klar�, hidrolik fren vb), su ar�tma, pigment ve kurutucu, n�kleer uygulamalar..", 5, yariMetaller, Bor);
        }

        private void C_Click(object sender, EventArgs e)
        {
            //KisaYaz("Karbon elementi do�ada �ok s�k rastlanan bir elementtir ve do�adaki bile�iklerin b�y�k bir k�sm�n�n yap�s�nda bulunur.", "�eliklerin sertle�tirilmesi, K�m�r, metan gaz�  ve ham petrollerde yak�t, yaz�c�lar ve boyama i�in m�rekkep yap�m�, pil, frenler ve ya�lay�c� yap�m�..", 6, "Ametaller", "Karbon (C)");
            MyMessageBox.ShowBox("Karbon (C)", $"Karbon elementi do�ada �ok s�k rastlanan bir elementtir ve do�adaki bile�iklerin b�y�k bir k�sm�n�n yap�s�nda bulunur.", "�eliklerin sertle�tirilmesi, k�m�r, metan gaz�  ve ham petrollerde yak�t, yaz�c�lar ve boyama i�in m�rekkep yap�m�, pil, frenler ve ya�lay�c� yap�m�..", 6, ametaller, Karbon);
        }
        private void N_Click(object sender, EventArgs e)
        {
            //KisaYaz("Di�er ismi nitrojen olan azot elementi, D�nya'n�n atmosferinde en fazla bulunan gazd�r. Renksiz ve kokusuz olan bu gaz, canl�lar�n yap�s�nda da bulunur.", "Amonyak yap�m�, g�bre yap�m�, patlay�c� yap�m�, boya �retimi..", 7, "Ametaller", "Azot (N)");
            MyMessageBox.ShowBox("Azot (N)","Di�er ismi nitrojen olan azot elementi, D�nya'n�n atmosferinde en fazla bulunan gazd�r. Renksiz ve kokusuz olan bu gaz, canl�lar�n yap�s�nda da bulunur.", "amonyak yap�m�, g�bre yap�m�, patlay�c� yap�m�, boya �retimi..", 7, ametaller, Azot);
        }

        private void O_Click(object sender, EventArgs e)
        {
            //KisaYaz("Oksijen, hidrojen ve helyum elementlerinden sonra do�ada k�tlesel olarak  en fazla bulunan elementtir. Havada, suda ve toprakta bulunur. Canl�lar�n solunumu i�in gereklidir.", "demir ve �elik gibi malzemelerin kesilmesi, dal�� t�plerini doldurmak..", 8, "Ametaller", "Oksijen (O)");
            MyMessageBox.ShowBox("Oksijen (O)", "Oksijen, hidrojen ve helyum elementlerinden sonra do�ada k�tlesel olarak en fazla bulunan elementtir. Havada, suda ve toprakta bulunur. Canl�lar�n solunumu i�in gereklidir.", "\ndemir ve �elik gibi malzemelerin kesilmesi, dal�� t�plerini doldurmak..", 8, ametaller, Oksijen); ;
        }

        private void F_Click(object sender, EventArgs e)
        {
            //KisaYaz("Flor, en reaktif elementtir.", "i�me sular�n�n mikroplardan ar�nd�r�lmas�, ampullerin camlar�n�n �zerine yaz� yaz�lmas�, havaland�rma ve so�utma aletlerinde, di� macunlar� ve deodorantlarda..", 9, halojenler, "Flor (F)");
            MyMessageBox.ShowBox("Flor (F)", "Flor, en reaktif elementtir.", "i�me sular�n�n mikroplardan ar�nd�r�lmas�, ampullerin camlar�n�n �zerine yaz� yaz�lmas�, havaland�rma ve so�utma aletleri, di� macunlar� ve deodorantlar..", 9, ametaller, Flor);
        }

        private void Ne_Click(object sender, EventArgs e)
        {
            KisaYaz("Renksiz ve kokusuz bir element olan neon, herhangi bir element ile tepkimeye girmez.", "televizyon t�pleri, renkli reklam ayd�nlatmalar�, paratonerler..", 10, "Soy Gazlar (Ametaller)", "Neon (Ne)", Neon);
        }

        private void Na_Click(object sender, EventArgs e)
        {
            KisaYaz("Do�ada en �ok bulunan elementlerden biri olan sodyum, do�ada kat� halde bulunur. Sodyum elementi; denizlerde, sofra tuzunda ve canl�lar�n yap�s�nda bulunur.", "sokak ayd�nlatmalar�, pil �retimi, cam yap�m�..", 11, alkaliMetaller, "Sodyum (Na)", Sodyum);
        }

        private void Mg_Click(object sender, EventArgs e)
        {
            KisaYaz("Magnezyum, Yery�z�nde en �ok bulunan elementlerden biridir. Canl�lar�n yap�s�nda, deniz suyunda bol miktarda bulunur.", "ila� �retimi, cam �retimi, u�ak par�alar�n�n �retimi, foto�raf makinelerinin g�vde ve fla� kaplamalar�..", 12, toprakAlkaliMetaller, "Magnezyum (Mg)", Magnezyum);
        }

        private void Al_Click(object sender, EventArgs e)
        {
            KisaYaz("Yery�z�nde �ok miktarda bulunan ve hafif bir element olan aliminyum elementi, kaya� ve minerallerin yap�lar�nda bulunur.", "i�ecek kutusu �retimi, CD �retimi; u�ak, roket ve bisiklet gibi ta��tlar�n g�vdesinin yap�m�.. ", 13, metaller, "Aliminyum (Al)", Aliminyum);
        }

        private void Si_Click(object sender, EventArgs e)
        {
            KisaYaz("Yery�z�nde en �ok miktarda bulunan elementlerden biri olan silisyum, bitkilerin, insan iskeletinin ve cam�n yap�s�nda bulunur. Kum ve kil, silisyum bile�i�idir.", "cam �retimi, sa� kremleri, seramik, tu�la..", 14, yariMetaller, "Silisyum (Si)", Silisyum);
        }

        private void P_Click(object sender, EventArgs e)
        {
            KisaYaz("Canl�larda sinir ve kemik dokular� i�in �ok �nemli olan fosfor, yan�c� bir elementtir. Karanl�kta parlama �zelli�ine sahip olan bu element, zehirlidir.", "havai fi�ek �retimi, kibrit �retimi, patlay�c� madde �retimi..", 15, ametaller, "Fosfor (P)", Fosfor);
        }

        private void S_Click(object sender, EventArgs e)
        {
            KisaYaz("Canl�lar i�in �ok �nemli olan k�k�rt elementi, genellikle yanarda� ve s�cak su kaynaklar�n�n yak�nlar�nda bulunur.", "barut �retimi, sabun �retimi..", 16, ametaller, "K�k�rt (S)", Kukurt);
        }

        private void Cl_Click(object sender, EventArgs e)
        {
            KisaYaz("Zehirli bir element olan klor elementi, sofra tuzu ve deniz suyunun yap�s�nda bulunur.", "i�me sular�n� ar�tma, y�zme havuzu suyunu temizleme..", 17, halojenler, "Klor (Cl)", Klor);
        }

        private void Ar_Click(object sender, EventArgs e)
        {
            KisaYaz("Atmosferde olduk�a nadir bulunan argon elementi, kokusuz ve renksiz bir gazd�r.", "elektrikli ayd�nlatma ampul� �retimi, floresan t�p �retimi, kesim ve kaynak i�lemeleri..", 18, soyGazlar, "Argon (Ar)", Argon);
        }

        private void K_Click(object sender, EventArgs e)
        {
            KisaYaz("Yumu�ak ve g�m��-beyaz renkli olan potasyum elementi, deniz suyunda ve pek �ok mineralde bulunur.", "g�bre sanayii, cam �retimi, deterjan ve s�v� sabun yap�m�..", 18, alkaliMetaller, "Potasyum (K)", Potasyum);
        }

        private void Ca_Click(object sender, EventArgs e)
        {
            KisaYaz("Elektri�i iyi ileten kalsiyum elementi, g�m�� gibi parlakt�r.", "kire�li har� yap�m�, �imento yap�m�, amonyak ve deterjan �retimi, suyun yumu�at�lmas�..", 20, toprakAlkaliMetaller, "Kalsiyum (Ca)", Kalsiyum);
        }

        private void Metaller_Click(object sender, EventArgs e)
        {
            if (isMBC == 2)
            {
                if (Metaller.Text == metaller) //AM
                {
                    Metaller.Text = "Alkali Metaller";
                    Metaller.BackColor = Color.DarkRed;
                    Li.BackColor = Color.DarkRed;
                    Na.BackColor = Color.DarkRed;
                    K.BackColor = Color.DarkRed;
                }
                else if (Metaller.Text == "Alkali Metaller") //TAM
                {
                    Metaller.Text = "Toprak Alkali Metaller";
                    Metaller.BackColor = Color.Firebrick;
                    Li.BackColor = Color.Red;
                    Na.BackColor = Color.Red;
                    K.BackColor = Color.Red;
                    Be.BackColor = Color.Firebrick;
                    Mg.BackColor = Color.Firebrick;
                    Ca.BackColor = Color.Firebrick;
                }
                else //M
                {
                    Metaller.Text = metaller;
                    Metaller.BackColor = Color.Red;
                    Be.BackColor = Color.Red;
                    Mg.BackColor = Color.Red;
                    Ca.BackColor = Color.Red;
                }
            }
        }
        private void Ametaller_Click(object sender, EventArgs e)
        {
            if (isABC == 2)
            {
                if (Ametaller.Text == ametaller) //SG
                {
                    Ametaller.Text = "Soy Gazlar";
                    Ametaller.BackColor = Color.DarkCyan;
                    He.BackColor = Color.DarkCyan;
                    Ne.BackColor = Color.DarkCyan;
                    Ar.BackColor = Color.DarkCyan;
                }
                else if (Ametaller.Text == "Soy Gazlar") //H
                {
                    Ametaller.Text = "Halojenler";
                    Ametaller.BackColor = Color.CornflowerBlue;
                    He.BackColor = Color.DeepSkyBlue;
                    Ne.BackColor = Color.DeepSkyBlue;
                    Ar.BackColor = Color.DeepSkyBlue;
                    F.BackColor = Color.CornflowerBlue;
                    Cl.BackColor = Color.CornflowerBlue;
                }
                else //A
                {
                    Ametaller.BackColor = Color.DeepSkyBlue;
                    Ametaller.Text = ametaller;
                    F.BackColor = Color.DeepSkyBlue;
                    Cl.BackColor = Color.DeepSkyBlue;
                }
            }
        }
        private void MB_Click(object sender, EventArgs e)
        {
            if (isMBC == 2) //Hepsi g�steriliyorsa
            {
                isMBC = 1;
                if (Metaller.Text == metaller)
                {
                    VisibilityOff(Li, Be, Na, Mg, Al, K, Ca, MB);
                }
                else if (Metaller.Text == "Alkali Metaller")
                {
                    VisibilityOff(Li, Na, K, MB);
                }
                else
                {
                    VisibilityOff(Be, Mg, Ca, MB);
                }
            }
            else
            {
                isMBC = 2;
                VisibilityOn();
            }
        }

        private void AB_Click(object sender, EventArgs e)
        {
            if (isABC == 2) //Hepsi g�steriliyorsa
            {
                isABC = 1;
                if (Ametaller.Text == ametaller)
                {
                    VisibilityOff(H, He, C, N, O, F, Ne, P, S, Cl, Ar, AB);
                }
                else if (Ametaller.Text == "Soy Gazlar")
                {
                    VisibilityOff(He, Ne, Ar, AB);
                }
                else
                {
                    VisibilityOff(F, Cl, AB);
                }
            }
            else
            {
                isABC = 2;
                VisibilityOn();
            }
        }

        private void YMB_Click(object sender, EventArgs e)
        {
            if (isYMBC == 2)
            {
                isYMBC = 1;
                VisibilityOff(B, Si, YMB);
            }
            else
            {
                isYMBC = 2;
                VisibilityOn();
            }
        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);


            Button[] elements = { H, He, Li, Be, B, C, N, O, F, Ne, Na, Mg, Al, Si, P, S, Cl, Ar, K, Ca };

            foreach (Button element in elements)
            {
                element.Height = 100000;
                element.Width = element.Height;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(buttonOriginalRectangle, tableLayoutPanel1);
            resizeControl(buttonOriginalRectangle1, tableLayoutPanel2);
        }
    }
}