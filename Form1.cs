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
        readonly string yariMetaller = "Yarý Metaller";
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
            //MessageBox.Show($"{aciklama}\nKullaným alanlarý : {kullanimAlanlari}\nAtom Numarasý : {AtomNumarasi}\nProton sayýsý : {AtomNumarasi}\nElektron sayýsý : {AtomNumarasi}\nBulunduðu Sýnýf : {sinif}", elementIsmi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            MyMessageBox.ShowBox(elementIsmi, aciklama, kullanimAlanlari, AtomNumarasi, sinif, image);
        }
        private void H_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Doðadaki en hafif element olan hidrojen; renksiz, kokusuz ve yanýcý bir elementtir.\nKullaným alanlarý : hidrojen balonlarýný þiþirme, petrolün iþlenmesi, amonyak yapýmý, roket yakýtlarý, yaðlarýn doyurulmasý..\nAtom Numarasý : 1\nProton sayýsý : 1\nElektron sayýsý : 1\nBulunduðu sýnýf : Ametaller", "Hidrojen Elementi (H)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MyMessageBox.ShowBox("Hidrojen (H)", "Doðadaki en hafif element olan hidrojen; renksiz, kokusuz ve yanýcý bir elementtir.", "hidrojen balonlarýnýnýn þiþirilmesi, petrolün iþlenmesi, amonyak yapýmý, roket yakýtlarý, yaðlarýn doyurulmasý..", 1, ametaller, Hidrojen);
        }

        private void He_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hidrojenden sonra en hafif element olan helyum elementi, renksiz ve kokusuz haldedir.\nKullaným alanlarý : zeplinler, uçan balonlar..\nAtom Numarasý : 2\nProton sayýsý : 2\nElektron sayýsý : 2\nBulunduðu sýnýf : Soy Gazlar (Ametaller)", "Helyum Elementi (He)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MyMessageBox.ShowBox("Helyum (He)", "Hidrojenden sonra en hafif element olan helyum elementi, renksiz ve kokusuz haldedir.","zeplinler, uçan balonlar..", 2, soyGazlar, Helyum);
        }

        private void Li_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Lityum, doðada yoðunluðu en az olan ve doðada saf haliyle bulunamayan yumuþak ve gümüþümsü beyaz bir elementtir.\nKullaným alanlarý : ilaç yapýmý, telefon, tablet, bilgisayar gibi teknolojik aletlerin bataryalarýnýn yapýmý, cam ve seramik.. \nAtom Numarasý : 3\nProton sayýsý : 3\nElektron sayýsý : 3\nBulunduðu sýnýf : " + alkaliMetaller, "Lityum Elementi (Li)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MyMessageBox.ShowBox("Lityum (Li)", "Lityum, doðada yoðunluðu en az olan ve doðada saf haliyle bulunamayan yumuþak ve gümüþümsü beyaz bir elementtir.", "ilaç yapýmý, telefon, tablet, bilgisayar gibi teknolojik aletlerin bataryalarýnýn yapýmý, cam ve seramik..", 3, alkaliMetaller, Lityum);
        }

        private void Be_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Berilyum, doðada nadir rastlanan ve çok az bulunan bir elementtir.\nKullaným alanlarý : Hava taþýtlarý, uzay araçlarý, füzeler ve iletiþim uydularýnda, nükleer reaktörlerde yansýtýcý ya da nötron düzenleyici..\nAtom Numarasý : 4\nProton sayýsý : 4\nElektron sayýsý : 4\nBulunduðu sýnýf : " + toprakAlkaliMetaller, "Berilyum (Be)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MyMessageBox.ShowBox("Berilyum (Be)", "Berilyum, doðada nadir rastlanan ve çok az bulunan bir elementtir.", "hava taþýtlarý, uzay araçlarý, füzeler ve iletiþim uydularý, nükleer reaktörlerde yansýtýcý ya da nötron düzenleyici..", 4, toprakAlkaliMetaller, Berilyum);
        }

        private void B_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Dünya'daki bor rezervinin %50'sinden fazlasý Türkiye'de bulunur.\nKullaným alanlarý : cam, seramik, deterjan, ilaç ve kimya sanayii, yanmayý önleyici (geciktirici) madde yapýmý, tarým, metalurji, enerji depolama, arabalar (hava yastýklarý, hidrolik fren vb), su arýtma, pigment ve kurutucu olarak, nükleer uygulamalar..\nAtom Numarasý: 5\nProton sayýsý: 5\nElektron sayýsý: 5\nBulunduðu sýnýf : Yarý Metaller", "Bor (B)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MyMessageBox.ShowBox("Bor (B)", "Dünya'daki bor rezervinin %50'sinden fazlasý Türkiye'de bulunur.", "cam, seramik, deterjan, ilaç ve kimya sanayii, yanmayý önleyici (geciktirici) madde yapýmý, tarým, metalurji, enerji depolama, arabalar (hava yastýklarý, hidrolik fren vb), su arýtma, pigment ve kurutucu, nükleer uygulamalar..", 5, yariMetaller, Bor);
        }

        private void C_Click(object sender, EventArgs e)
        {
            //KisaYaz("Karbon elementi doðada çok sýk rastlanan bir elementtir ve doðadaki bileþiklerin büyük bir kýsmýnýn yapýsýnda bulunur.", "Çeliklerin sertleþtirilmesi, Kömür, metan gazý  ve ham petrollerde yakýt, yazýcýlar ve boyama için mürekkep yapýmý, pil, frenler ve yaðlayýcý yapýmý..", 6, "Ametaller", "Karbon (C)");
            MyMessageBox.ShowBox("Karbon (C)", $"Karbon elementi doðada çok sýk rastlanan bir elementtir ve doðadaki bileþiklerin büyük bir kýsmýnýn yapýsýnda bulunur.", "çeliklerin sertleþtirilmesi, kömür, metan gazý  ve ham petrollerde yakýt, yazýcýlar ve boyama için mürekkep yapýmý, pil, frenler ve yaðlayýcý yapýmý..", 6, ametaller, Karbon);
        }
        private void N_Click(object sender, EventArgs e)
        {
            //KisaYaz("Diðer ismi nitrojen olan azot elementi, Dünya'nýn atmosferinde en fazla bulunan gazdýr. Renksiz ve kokusuz olan bu gaz, canlýlarýn yapýsýnda da bulunur.", "Amonyak yapýmý, gübre yapýmý, patlayýcý yapýmý, boya üretimi..", 7, "Ametaller", "Azot (N)");
            MyMessageBox.ShowBox("Azot (N)","Diðer ismi nitrojen olan azot elementi, Dünya'nýn atmosferinde en fazla bulunan gazdýr. Renksiz ve kokusuz olan bu gaz, canlýlarýn yapýsýnda da bulunur.", "amonyak yapýmý, gübre yapýmý, patlayýcý yapýmý, boya üretimi..", 7, ametaller, Azot);
        }

        private void O_Click(object sender, EventArgs e)
        {
            //KisaYaz("Oksijen, hidrojen ve helyum elementlerinden sonra doðada kütlesel olarak  en fazla bulunan elementtir. Havada, suda ve toprakta bulunur. Canlýlarýn solunumu için gereklidir.", "demir ve çelik gibi malzemelerin kesilmesi, dalýþ tüplerini doldurmak..", 8, "Ametaller", "Oksijen (O)");
            MyMessageBox.ShowBox("Oksijen (O)", "Oksijen, hidrojen ve helyum elementlerinden sonra doðada kütlesel olarak en fazla bulunan elementtir. Havada, suda ve toprakta bulunur. Canlýlarýn solunumu için gereklidir.", "\ndemir ve çelik gibi malzemelerin kesilmesi, dalýþ tüplerini doldurmak..", 8, ametaller, Oksijen); ;
        }

        private void F_Click(object sender, EventArgs e)
        {
            //KisaYaz("Flor, en reaktif elementtir.", "içme sularýnýn mikroplardan arýndýrýlmasý, ampullerin camlarýnýn üzerine yazý yazýlmasý, havalandýrma ve soðutma aletlerinde, diþ macunlarý ve deodorantlarda..", 9, halojenler, "Flor (F)");
            MyMessageBox.ShowBox("Flor (F)", "Flor, en reaktif elementtir.", "içme sularýnýn mikroplardan arýndýrýlmasý, ampullerin camlarýnýn üzerine yazý yazýlmasý, havalandýrma ve soðutma aletleri, diþ macunlarý ve deodorantlar..", 9, ametaller, Flor);
        }

        private void Ne_Click(object sender, EventArgs e)
        {
            KisaYaz("Renksiz ve kokusuz bir element olan neon, herhangi bir element ile tepkimeye girmez.", "televizyon tüpleri, renkli reklam aydýnlatmalarý, paratonerler..", 10, "Soy Gazlar (Ametaller)", "Neon (Ne)", Neon);
        }

        private void Na_Click(object sender, EventArgs e)
        {
            KisaYaz("Doðada en çok bulunan elementlerden biri olan sodyum, doðada katý halde bulunur. Sodyum elementi; denizlerde, sofra tuzunda ve canlýlarýn yapýsýnda bulunur.", "sokak aydýnlatmalarý, pil üretimi, cam yapýmý..", 11, alkaliMetaller, "Sodyum (Na)", Sodyum);
        }

        private void Mg_Click(object sender, EventArgs e)
        {
            KisaYaz("Magnezyum, Yeryüzünde en çok bulunan elementlerden biridir. Canlýlarýn yapýsýnda, deniz suyunda bol miktarda bulunur.", "ilaç üretimi, cam üretimi, uçak parçalarýnýn üretimi, fotoðraf makinelerinin gövde ve flaþ kaplamalarý..", 12, toprakAlkaliMetaller, "Magnezyum (Mg)", Magnezyum);
        }

        private void Al_Click(object sender, EventArgs e)
        {
            KisaYaz("Yeryüzünde çok miktarda bulunan ve hafif bir element olan aliminyum elementi, kayaç ve minerallerin yapýlarýnda bulunur.", "içecek kutusu üretimi, CD üretimi; uçak, roket ve bisiklet gibi taþýtlarýn gövdesinin yapýmý.. ", 13, metaller, "Aliminyum (Al)", Aliminyum);
        }

        private void Si_Click(object sender, EventArgs e)
        {
            KisaYaz("Yeryüzünde en çok miktarda bulunan elementlerden biri olan silisyum, bitkilerin, insan iskeletinin ve camýn yapýsýnda bulunur. Kum ve kil, silisyum bileþiðidir.", "cam üretimi, saç kremleri, seramik, tuðla..", 14, yariMetaller, "Silisyum (Si)", Silisyum);
        }

        private void P_Click(object sender, EventArgs e)
        {
            KisaYaz("Canlýlarda sinir ve kemik dokularý için çok önemli olan fosfor, yanýcý bir elementtir. Karanlýkta parlama özelliðine sahip olan bu element, zehirlidir.", "havai fiþek üretimi, kibrit üretimi, patlayýcý madde üretimi..", 15, ametaller, "Fosfor (P)", Fosfor);
        }

        private void S_Click(object sender, EventArgs e)
        {
            KisaYaz("Canlýlar için çok önemli olan kükürt elementi, genellikle yanardað ve sýcak su kaynaklarýnýn yakýnlarýnda bulunur.", "barut üretimi, sabun üretimi..", 16, ametaller, "Kükürt (S)", Kukurt);
        }

        private void Cl_Click(object sender, EventArgs e)
        {
            KisaYaz("Zehirli bir element olan klor elementi, sofra tuzu ve deniz suyunun yapýsýnda bulunur.", "içme sularýný arýtma, yüzme havuzu suyunu temizleme..", 17, halojenler, "Klor (Cl)", Klor);
        }

        private void Ar_Click(object sender, EventArgs e)
        {
            KisaYaz("Atmosferde oldukça nadir bulunan argon elementi, kokusuz ve renksiz bir gazdýr.", "elektrikli aydýnlatma ampulü üretimi, floresan tüp üretimi, kesim ve kaynak iþlemeleri..", 18, soyGazlar, "Argon (Ar)", Argon);
        }

        private void K_Click(object sender, EventArgs e)
        {
            KisaYaz("Yumuþak ve gümüþ-beyaz renkli olan potasyum elementi, deniz suyunda ve pek çok mineralde bulunur.", "gübre sanayii, cam üretimi, deterjan ve sývý sabun yapýmý..", 18, alkaliMetaller, "Potasyum (K)", Potasyum);
        }

        private void Ca_Click(object sender, EventArgs e)
        {
            KisaYaz("Elektriði iyi ileten kalsiyum elementi, gümüþ gibi parlaktýr.", "kireçli harç yapýmý, çimento yapýmý, amonyak ve deterjan üretimi, suyun yumuþatýlmasý..", 20, toprakAlkaliMetaller, "Kalsiyum (Ca)", Kalsiyum);
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
            if (isMBC == 2) //Hepsi gösteriliyorsa
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
            if (isABC == 2) //Hepsi gösteriliyorsa
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