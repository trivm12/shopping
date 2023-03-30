using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ShoppingOnlineApp
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = Properties.Resources._1;
            title1.Text = "Mobuseka vol1";
            title2.Text = "80.000 VND";
            pictureBox2.BackgroundImage = Properties.Resources._2;
            title3.Text = "Mobuseka vol2";
            title4.Text = "89.000 VND";
            pictureBox3.BackgroundImage = Properties.Resources._3;
            title5.Text = "Mobuseka vol3";
            title6.Text = "124.000 VND";
            pictureBox4.BackgroundImage = Properties.Resources._4;
            title7.Text = "Mobuseka vol4";
            title8.Text = "122.000 VND";
            pictureBox5.BackgroundImage = Properties.Resources._5;
            title9.Text = "Mobuseka vol5";
            title10.Text = "117.000 VND";
            pictureBox6.BackgroundImage = Properties.Resources._6;
            title11.Text = "Roshidere vol1";
            title12.Text = "98.000 VND";
            pictureBox7.BackgroundImage = Properties.Resources._7;
            title13.Text = "Rabudame vol1";
            title14.Text = "111.000 VND";
            pictureBox8.BackgroundImage = Properties.Resources._8;
            title15.Text = "UM vol1";
            title16.Text = "109.000 VND";
            pictureBox9.BackgroundImage = Properties.Resources._9;
            title17.Text = "Colorful";
            title18.Text = "68.000 VND";
            pictureBox10.BackgroundImage = Properties.Resources._10;
            title19.Text = "Your name";
            title20.Text = "76.000 VND";
            string ViewRecordFile = @"E:\CS511\example\shopping_with_no_sql_original\Resources\ViewFileRecord.txt";
            if (File.Exists(ViewRecordFile) == false)
                File.Create(ViewRecordFile).Close();

        }
        string newPath = @"E:\CS511\example\shopping_with_no_sql_original\Resources\CartRecord.txt";
        string ViewRecordFile = @"E:\CS511\example\shopping_with_no_sql_original\Resources\ViewFileRecord.txt";
        int Flag1 = 1;
        int Flag2 = 2;
        int Flag3 = 3;
        int Flag4 = 4;
        int Flag5 = 5;
        int Flag6 = 6;
        int Flag7 = 7;
        int Flag8 = 8;
        int Flag9 = 9;
        int Flag10 = 10;
        int Flag = 0;

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LNbutton_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources._1;
            title1.Text = "Mobuseka vol1";
            title2.Text = "80.000 VND";
            pictureBox2.BackgroundImage = Properties.Resources._2;
            title3.Text = "Mobuseka vol2";
            title4.Text = "89.000 VND";
            pictureBox3.BackgroundImage = Properties.Resources._3;
            title5.Text = "Mobuseka vol3";
            title6.Text = "124.000 VND";
            pictureBox4.BackgroundImage = Properties.Resources._4;
            title7.Text = "Mobuseka vol4";
            title8.Text = "122.000 VND";
            pictureBox5.BackgroundImage = Properties.Resources._5;
            title9.Text = "Mobuseka vol5";
            title10.Text = "117.000 VND";
            pictureBox6.BackgroundImage = Properties.Resources._6;
            title11.Text = "Roshidere vol1";
            title12.Text = "98.000 VND";
            pictureBox7.BackgroundImage = Properties.Resources._7;
            title13.Text = "Rabudame vol1";
            title14.Text = "111.000 VND";
            pictureBox8.BackgroundImage = Properties.Resources._8;
            title15.Text = "UM vol1";
            title16.Text = "109.000 VND";
            pictureBox9.BackgroundImage = Properties.Resources._9;
            title17.Text = "Colorful";
            title18.Text = "68.000 VND";
            pictureBox10.BackgroundImage = Properties.Resources._10;
            title19.Text = "Your name";
            title20.Text = "76.000 VND";
            Flag1 = 1;
            Flag2 = 2;
            Flag3 = 3;
            Flag4 = 4;
            Flag5 = 5;
            Flag6 = 6;
            Flag7 = 7;
            Flag8 = 8;
            Flag9 = 9;
            Flag10 = 10;
        }

        private void KNSButton_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources._11;
            title1.Text = "Tư duy phản biện";
            title2.Text = "156.000 VND";
            pictureBox2.BackgroundImage = Properties.Resources._12;
            title3.Text = "Đi tìm lẽ sống";
            title4.Text = "89.000 VND";
            pictureBox3.BackgroundImage = Properties.Resources._13;
            title5.Text = "Đánh thức tiềm năng";
            title6.Text = "96.000 VND";
            pictureBox4.BackgroundImage = Properties.Resources._14;
            title7.Text = "Phải trái đúng sai";
            title8.Text = "117.000 VND";
            pictureBox5.BackgroundImage = Properties.Resources._15;
            title9.Text = "TT đáng giá bao nhiêu";
            title10.Text = "79.000 VND";
            pictureBox6.BackgroundImage = Properties.Resources._16;
            title11.Text = "Đắc nhân tâm";
            title12.Text = "146.000 VND";
            pictureBox7.BackgroundImage = Properties.Resources._17;
            title13.Text = "Súng, VT và Thép";
            title14.Text = "207.000 VND";
            pictureBox8.BackgroundImage = Properties.Resources._18;
            title15.Text = "Tôi tự học";
            title16.Text = "92.000 VND";
            pictureBox9.BackgroundImage = Properties.Resources._20;
            title17.Text = "EQ";
            title18.Text = "106.000 VND";
            pictureBox10.BackgroundImage = Properties.Resources._19;
            title19.Text = "Bạn không TM lắm đâu";
            title20.Text = "97.000 VND";
            Flag1 = 11;
            Flag2 = 12;
            Flag3 = 13;
            Flag4 = 14;
            Flag5 = 15;
            Flag6 = 16;
            Flag7 = 17;
            Flag8 = 18;
            Flag9 = 19;
            Flag10 = 20;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources._21;
            title1.Text = "SpyxFamily vol1";
            title2.Text = "46.000 VND";
            pictureBox2.BackgroundImage = Properties.Resources._22;
            title3.Text = "SpyxFamily vol2";
            title4.Text = "59.000 VND";
            pictureBox3.BackgroundImage = Properties.Resources._23;
            title5.Text = "SpyxFamily vol3";
            title6.Text = "43.000 VND";
            pictureBox4.BackgroundImage = Properties.Resources._24;
            title7.Text = "SpyxFamily vol4";
            title8.Text = "47.000 VND";
            pictureBox5.BackgroundImage = Properties.Resources._25;
            title9.Text = "Jujutsu Kaisen vol1";
            title10.Text = "56.000 VND";
            pictureBox6.BackgroundImage = Properties.Resources._26;
            title11.Text = "Jujutsu Kaisen vol2";
            title12.Text = "54.000 VND";
            pictureBox7.BackgroundImage = Properties.Resources._27;
            title13.Text = "Kaguya-sama vol1";
            title14.Text = "37.000 VND";
            pictureBox8.BackgroundImage = Properties.Resources._28;
            title15.Text = "Tonikaku Kawaii vol1";
            title16.Text = "42.000 VND";
            pictureBox9.BackgroundImage = Properties.Resources._29;
            title17.Text = "Tonikaku Kawaii vol2";
            title18.Text = "46.000 VND";
            pictureBox10.BackgroundImage = Properties.Resources._30;
            title19.Text =  "Tonikaku Kawaii vol3";
            title20.Text =  "39.000 VND";
            Flag1 = 21;
            Flag2 = 22;
            Flag3 = 23;
            Flag4 = 24;
            Flag5 = 25;
            Flag6 = 26;
            Flag7 = 27;
            Flag8 = 28;
            Flag9 = 29;
            Flag10 = 30;
        }
        string path;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ItemDisplayPanel.Visible = true;
            Flag = Flag1;
            switch (Flag)
            {
                case 1:
                    ItemDisplayPictureBox.Image = Properties.Resources._1;
                    ItemNameLabel.Text = "Mobuseka - Thế giới Otome Game thật \nkhắc nghiệt với nhân vật quần chúng \ntập 1 - Tác giả: Mishima Yomu";
                    ItemPriceLabel.Text = "80.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\1.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" +"Mobuseka - Thế giới Otome Game thật khắc nghiệt với nhân vật quần chúng tập 1 - Tác giả: Mishima Yomu\n");
                    break;
                case 11:
                    ItemDisplayPictureBox.Image = Properties.Resources._11;
                    ItemNameLabel.Text = "Nghệ thuật tư duy phản biện \n- Tác giả: Albert Rutherford";
                    ItemPriceLabel.Text = "156.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\11.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Nghệ thuật tư duy phản biện - Tác giả: Albert Rutherford\n");
                    break;
                case 21:
                    ItemDisplayPictureBox.Image = Properties.Resources._21;
                    ItemNameLabel.Text = "Spy x Family tập 1\n- Tác giả: Tatsuya Endo";
                    ItemPriceLabel.Text = "46.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\21.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Spy x Family tập 1 - Tác giả: Tatsuya Endo\n");
                    break;
            }
                   
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ItemDisplayPanel.Visible = true;
            Flag = Flag2;
            switch (Flag)
            {
                case 2:
                    ItemDisplayPictureBox.Image = Properties.Resources._2;
                    ItemNameLabel.Text = "Mobuseka - Thế giới Otome Game thật \nkhắc nghiệt với nhân vật quần chúng \ntập 2 - Tác giả: Mishima Yomu";
                    ItemPriceLabel.Text = "89.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\2.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Mobuseka - Thế giới Otome Game thật khắc nghiệt với nhân vật quần chúng tập 2 - Tác giả: Mishima Yomu\n");
                    break;
                case 12:
                    ItemDisplayPictureBox.Image = Properties.Resources._12;
                    ItemNameLabel.Text = "Đi tìm lẽ sống\n- Tác giả: Viktor E. Frankl";
                    ItemPriceLabel.Text = "89.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\12.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Đi tìm lẽ sống - Tác giả: Viktor E. Frankl\n");
                    break;
                case 22:
                    ItemDisplayPictureBox.Image = Properties.Resources._22;
                    ItemNameLabel.Text = "Spy x Family tập 2\n- Tác giả: Tatsuya Endo";
                    ItemPriceLabel.Text = "89.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\22.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Spy x Family tập 2 - Tác giả: Tatsuya Endo\n");
                    break;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ItemDisplayPanel.Visible = true;
            Flag = Flag3;
            switch (Flag)
            {
                case 3:
                    ItemDisplayPictureBox.Image = Properties.Resources._3;
                    ItemNameLabel.Text = "Mobuseka - Thế giới Otome Game thật \nkhắc nghiệt với nhân vật quần chúng \ntập 3 - Tác giả: Mishima Yomu";
                    ItemPriceLabel.Text = "124.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\3.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Mobuseka - Thế giới Otome Game thật khắc nghiệt với nhân vật quần chúng tập 3 - Tác giả: Mishima Yomu\n");
                    break;
                case 13:
                    ItemDisplayPictureBox.Image = Properties.Resources._13;
                    ItemNameLabel.Text = "Đánh thức con người phi thường \ntrong bạn - Tác giả: Anthony Robbins";
                    ItemPriceLabel.Text = "96.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\13.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Đánh thức con người phi thường trong bạn - Tác giả: Anthony Robbins\n");
                    break;
                case 23:
                    ItemDisplayPictureBox.Image = Properties.Resources._23;
                    ItemNameLabel.Text = "Spy x Family tập 3\n- Tác giả: Tatsuya Endo";
                    ItemPriceLabel.Text = "43.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\23.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Spy x Family tập 3 - Tác giả: Tatsuya Endo\n");
                    break;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ItemDisplayPanel.Visible = true;
            Flag = Flag4;
            switch (Flag)
            {
                case 4:
                    ItemDisplayPictureBox.Image = Properties.Resources._4;
                    ItemNameLabel.Text = "Mobuseka - Thế giới Otome Game thật \nkhắc nghiệt với nhân vật quần chúng \ntập 4 - Tác giả: Mishima Yomu";
                    ItemPriceLabel.Text = "122.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\4.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Mobuseka - Thế giới Otome Game thật khắc nghiệt với nhân vật quần chúng tập 4 - Tác giả: Mishima Yomu\n");
                    break;
                case 14:
                    ItemDisplayPictureBox.Image = Properties.Resources._14;
                    ItemNameLabel.Text = "Phải trái đúng sai\n- Tác giả: Michael Sandels";
                    ItemPriceLabel.Text = "117.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\14.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Phải trái đúng sai - Tác giả: Michael Sandels\n");
                    break;
                case 24:
                    ItemDisplayPictureBox.Image = Properties.Resources._24;
                    ItemNameLabel.Text = "Spy x Family tập 4\n- Tác giả: Tatsuya Endo";
                    ItemPriceLabel.Text = "47.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\24.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Spy x Family tập 4 - Tác giả: Tatsuya Endo\n");
                    break;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ItemDisplayPanel.Visible = true;
            Flag = Flag5;
            switch (Flag)
            {
                case 5:
                    ItemDisplayPictureBox.Image = Properties.Resources._5;
                    ItemNameLabel.Text = "Mobuseka - Thế giới Otome Game thật \nkhắc nghiệt với nhân vật quần chúng \ntập 5 - Tác giả: Mishima Yomu";
                    ItemPriceLabel.Text = "117.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\5.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Mobuseka - Thế giới Otome Game thật khắc nghiệt với nhân vật quần chúng tập 5 - Tác giả: Mishima Yomu\n");
                    break;
                case 15:
                    ItemDisplayPictureBox.Image = Properties.Resources._15;
                    ItemNameLabel.Text = "Tuổi trẻ đáng giá bao nhiêu ?\n- Tác giả: Rosie Nguyễn";
                    ItemPriceLabel.Text = "79.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\15.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Tuổi trẻ đáng giá bao nhiêu ? - Tác giả: Rosie Nguyễn\n");
                    break;
                case 25:
                    ItemDisplayPictureBox.Image = Properties.Resources._25;
                    ItemNameLabel.Text = "Jujutsu Kaisen - Chú thuật hồi chiến \ntập 1 - Tác giả: Gege Akutami";
                    ItemPriceLabel.Text = "56.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\25.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Jujutsu Kaisen - Chú thuật hồi chiến tập 1 - Tác giả: Gege Akutami\n");
                    break;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ItemDisplayPanel.Visible = true;
            Flag = Flag6;
            switch (Flag)
            {
                case 6:
                    ItemDisplayPictureBox.Image = Properties.Resources._6;
                    ItemNameLabel.Text = "Roshidere - Arya bàn bên lúc nào cũng \nchọc ghẹo tôi bằng tiếng nga \n- Tác giả: 燦々SUN";
                    ItemPriceLabel.Text = "98.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\6.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Roshidere - Arya bàn bên lúc nào cũng chọc ghẹo tôi bằng tiếng nga - Tác giả: 燦々SUN\n");
                    break;
                case 16:
                    ItemDisplayPictureBox.Image = Properties.Resources._16;
                    ItemNameLabel.Text = "Đắc nhân tâm \n- Tác giả: Dale Carnegie";
                    ItemPriceLabel.Text = "146.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\16.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Đắc nhân tâm - Tác giả: Dale Carnegie\n");
                    break;
                case 26:
                    ItemDisplayPictureBox.Image = Properties.Resources._26;
                    ItemNameLabel.Text = "Jujutsu Kaisen - Chú thuật hồi chiến \ntập 2 - Tác giả: Gege Akutami";
                    ItemPriceLabel.Text = "54.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\26.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Jujutsu Kaisen - Chú thuật hồi chiến tập 2 - Tác giả: Gege Akutami\n");
                    break;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ItemDisplayPanel.Visible = true;
            Flag = Flag7;
            switch (Flag)
            {
                case 7:
                    ItemDisplayPictureBox.Image = Properties.Resources._7;
                    ItemNameLabel.Text = "Rabudame - Ai dám bảo Romcom\n không có ngoài đời thực\n- Tác giả: Hajikano Sou";
                    ItemPriceLabel.Text = "111.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\7.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Rabudame - Ai dám bảo Romcom không có ngoài đời thực - Tác giả: Hajikano Sou\n");
                    break;
                case 17:
                    ItemDisplayPictureBox.Image = Properties.Resources._17;
                    ItemNameLabel.Text = "Súng, vi trùng và thép\n- Tác giả: Jared Damon";
                    ItemPriceLabel.Text = "207.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\17.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Súng, vi trùng và thép - Tác giả: Jared Damon\n");
                    break;
                case 27:
                    ItemDisplayPictureBox.Image = Properties.Resources._27;
                    ItemNameLabel.Text = "Kaguya-sama, Cuộc chiến tỏ tình tập 1\n- Tác giả: Akasaka Aka";
                    ItemPriceLabel.Text = "37.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\27.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Kaguya-sama, Cuộc chiến tỏ tình tập 1 - Tác giả: Akasaka Aka\n");
                    break;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ItemDisplayPanel.Visible = true;
            Flag = Flag8;
            switch (Flag)
            {
                case 8:
                    ItemDisplayPictureBox.Image = Properties.Resources._8;
                    ItemNameLabel.Text = "Unnamed Memory, Hồi úc không tên\ntập 1 - Tác giả: Kuji Furumiya";
                    ItemPriceLabel.Text = "109.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\8.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Unnamed Memory, Hồi úc không tên tập 1 - Tác giả: Kuji Furumiya\n");
                    break;
                case 18:
                    ItemDisplayPictureBox.Image = Properties.Resources._18;
                    ItemNameLabel.Text = "Tôi tự học - Tác giả: Nguyễn Duy Cần";
                    ItemPriceLabel.Text = "92.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\18.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Tôi tự học - Tác giả: Nguyễn Duy Cần\n");
                    break;
                case 28:
                    ItemDisplayPictureBox.Image = Properties.Resources._28;
                    ItemNameLabel.Text = "Tonikaku Kawaii - Tóm lại là em\n dễ thương, được chưa ? \n- tập 1 - Tác giả: Kenjirou Hata";
                    ItemPriceLabel.Text = "42.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\28.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Tonikaku Kawaii - Tóm lại là em dễ thương, được chưa ? - tập 1 - Tác giả: Kenjirou Hata\n");
                    break;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ItemDisplayPanel.Visible = true;
            Flag = Flag9;
            switch (Flag)
            {
                case 9:
                    ItemDisplayPictureBox.Image = Properties.Resources._9;
                    ItemNameLabel.Text = "Colorful, Sắc màu\n- Tác giả: Eto Mori";
                    ItemPriceLabel.Text = "68.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\9.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Colorful, Sắc màu - Tác giả: Eto Mori\n");
                    break;
                case 19:
                    ItemDisplayPictureBox.Image = Properties.Resources._20;
                    ItemNameLabel.Text = "EQ, Trí thông minh xúc cảm\ntrong công việc\n- Tác giả: Justin Bariso";
                    ItemPriceLabel.Text = "106.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\20.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "EQ, Trí thông minh xúc cảm trong công việc - Tác giả: Justin Bariso\n");
                    break;
                case 29:
                    ItemDisplayPictureBox.Image = Properties.Resources._29;
                    ItemNameLabel.Text = "Tonikaku Kawaii - Tóm lại là em\n dễ thương, được chưa ? \n- tập 2 - Tác giả: Kenjirou Hata";
                    ItemPriceLabel.Text = "42.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\29.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Tonikaku Kawaii - Tóm lại là em dễ thương, được chưa ? - tập 2 - Tác giả: Kenjirou Hata\n");
                    break;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ItemDisplayPanel.Visible = true;
            Flag = Flag10;
            switch(Flag)
            {
                case 10:
                    ItemDisplayPictureBox.Image = Properties.Resources._10;
                    ItemNameLabel.Text = "Your name - Tác giả: Shinkai Makoto";
                    ItemPriceLabel.Text = "76.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\10.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Your name - Tác giả: Shinkai Makoto\n");
                    break;
                case 20:
                    ItemDisplayPictureBox.Image = Properties.Resources._19;
                    ItemNameLabel.Text = "Bạn không thông minh lắm đâu \n- Tác giả: David McRaney";
                    ItemPriceLabel.Text = "97.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\19.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Bạn không thông minh lắm đâu - Tác giả: David McRaney\n");
                    break;
                case 30:
                    ItemDisplayPictureBox.Image = Properties.Resources._30;
                    ItemNameLabel.Text = "Tonikaku Kawaii - Tóm lại là em\n dễ thương, được chưa ? \n- tập 3 - Tác giả: Kenjirou Hata";
                    ItemPriceLabel.Text = "42.000 VND";
                    path = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Description\30.txt";
                    if (File.Exists(path))
                    {
                        var tmp = File.ReadAllText(path);
                        DescriptionBox.Text = tmp;
                    }
                    File.AppendAllText(ViewRecordFile, DateTime.Now.ToString() + "\t" + "Tonikaku Kawaii - Tóm lại là em dễ thương, được chưa ? - tập 3 - Tác giả: Kenjirou Hata\n");
                    break;
            }
            //MessageBox.Show("work" + Flag5.ToString());
        }

        private void ItemReturnButton_Click(object sender, EventArgs e)
        {
            ItemDisplayPanel.Visible = false;
        }
        private void BuyButton_Click(object sender, EventArgs e)
        {
            string BookName = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Tổng hợp\NameOfAllBooks.txt";
            string newPath = @"E:\CS511\example\shopping_with_no_sql_original\Resources\CartRecord.txt";
            if (File.Exists(newPath) == false)
                File.Create(newPath).Close();
            string line = File.ReadLines(BookName).Skip(Flag-1).Take(1).First();
            line = line + " - Số lượng: " + SoLuongSanPham.Value.ToString() + "\n";
            File.AppendAllText(newPath, line);
            SoLuongSanPham.Value = Convert.ToDecimal(1);
            ItemDisplayPanel.Visible = false;
        }

        private void ShoppingCartButton_Click(object sender, EventArgs e)
        {
            CartPanel.Visible = true;
            ItemDisplayPanel.Visible = false;
            string filePath = @"E:\CS511\example\shopping_with_no_sql_original\Resources\CartRecord.txt";
            if (System.IO.File.Exists(filePath))
                CartCheckListBox.Items.AddRange(System.IO.File.ReadAllLines(filePath));
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            CartPanel.Visible = false;
            ItemDisplayPanel.Visible = false;
            CartCheckListBox.Items.Clear();
            AccountPanel.Visible = false;
        }

        private void CartExitButton_Click(object sender, EventArgs e)
        {
            CartPanel.Visible=false;
            CartCheckListBox.Items.Clear();
        }

        private int TakeNumbersOfItem(string Line)
        {
            string[] collection = Line.Split(' ');
            string string2 = collection[collection.Length - 1];
            return Convert.ToInt32(string2);
        }

        private int TakePosOfItem(string Line)
        {
            int pos = 0;
            string BookName = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Tổng hợp\NameOfAllBooks.txt";
            string[] BookNameArray = File.ReadAllLines(BookName);
            int end = Line.IndexOf(" - Số lượng: ");
            string string1 = Line.Substring(0, end);
            for(int i = 0; i < BookNameArray.Length; i++)
            {
                if (BookNameArray[i] == string1)
                    pos = i + 1;
            }
            return pos;
        }

        Int32 TotalMoney = 0;
        private void ContinueCartButton_Click(object sender, EventArgs e)
        {
            string PricePath = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Tổng hợp\Price.txt";
            string filePath = @"E:\CS511\example\shopping_with_no_sql_original\Resources\CartRecord.txt";
            string[] NewContent = File.ReadAllLines(filePath);
            if (NewContent.Length > 0)
            {
                for (var i = 0; i < NewContent.Length; i++)
                {
                    int pos = TakePosOfItem(NewContent[i]);
                    int NumberOfItem = TakeNumbersOfItem(NewContent[i]);
                    string Price = File.ReadLines(PricePath).Skip(pos - 1).Take(1).First();
                    TotalMoney = TotalMoney + NumberOfItem * Convert.ToInt32(Price);
                }

                string CountPackage = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Hóa đơn\Count.txt";
                int count = Convert.ToInt32(File.ReadLines(CountPackage).First());
                string id = "id " + (count + 1).ToString();
                ItemIDTextBox.Text = id;
                MoneyTextBox.Text = TotalMoney.ToString();

                CustomDeleteLineFromTextFile(CountPackage, count.ToString());
                File.AppendAllText(CountPackage, (count + 1).ToString());
                CartPanel.Visible = false;
                FillFormAndPayMoneyPanel.Visible = true;
            }
            else { MessageBox.Show("Oops, Bạn chưa có gì trong giỏ hàng cả"); }
        }
        private void CustomDeleteLineFromTextFile(string PathToFile, string DeleteLine)
        {
            var tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(PathToFile).Where(l => l != DeleteLine);

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(PathToFile);
            File.Move(tempFile, PathToFile);
        }
        private void DeleteCartItemButton_Click(object sender, EventArgs e)
        {
            string newPath1 = @"E:\CS511\example\shopping_with_no_sql_original\Resources\CartRecord.txt";
            while (CartCheckListBox.CheckedItems.Count > 0)
            {
                string tmpLine = CartCheckListBox.CheckedItems[0].ToString();
                CustomDeleteLineFromTextFile(newPath1, tmpLine);
                CartCheckListBox.Items.Remove(CartCheckListBox.CheckedItems[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillFormAndPayMoneyPanel.Visible = false;
            CartPanel.Visible = true;
            TotalMoney = 0;
            string CountPackage = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Hóa đơn\Count.txt";
            int count = Convert.ToInt32(File.ReadLines(CountPackage).First());
            CustomDeleteLineFromTextFile(CountPackage, count.ToString());
            File.AppendAllText(CountPackage, (count - 1).ToString());
        }
        string IDHoaDonPath = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Hóa đơn\Mã hóa đơn.txt";
        private void PayingMoneyButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(IDHoaDonPath) == false)
                File.Create(IDHoaDonPath).Close();
            string CourtDataPath = @"E:\CS511\example\shopping_with_no_sql_original\Resources\Hóa đơn\";
            string filePath = @"E:\CS511\example\shopping_with_no_sql_original\Resources\CartRecord.txt";
            string id = ItemIDTextBox.Text;
            CourtDataPath = CourtDataPath + id + ".txt";
            if (File.Exists(CourtDataPath) == false)
                File.Create(CourtDataPath).Close();
            File.AppendAllText(CourtDataPath, "Họ và tên người nhận: " + NameTextBox.Text + "\n");
            File.AppendAllText(CourtDataPath,"Địa chỉ người nhận: " + AddressTextBox.Text + "\n");
            File.AppendAllText(CourtDataPath, "Số điện thoại người nhận: " + PhoneTextBox.Text + "\n" );
            File.AppendAllText(CourtDataPath, "Email người nhận: " + EmailTextBox.Text + "\n");
            File.AppendAllText(CourtDataPath, "Mã đơn hàng: " + ItemIDTextBox.Text + "\n");
            File.AppendAllText(CourtDataPath, "Thành tiền đơn hàng: " + MoneyTextBox.Text + "\n");
            File.AppendAllText(CourtDataPath, "\nDANH SÁCH SẢN PHẨM:\n");
            string tmp = File.ReadAllText(filePath);
            File.AppendAllText(CourtDataPath, tmp);
            File.AppendAllText(IDHoaDonPath, id + ".txt\n");
            MessageBox.Show("Bạn đã đặt hàng thành công\nĐơn hang sẽ được giao sau 15 ngày");
            File.WriteAllText(filePath, string.Empty);
            CartPanel.Visible = false;
            FillFormAndPayMoneyPanel.Visible = false;
            NameTextBox.Text = "";
            AddressTextBox.Text = "";
            PhoneTextBox.Text = "";
            EmailTextBox.Text = "";
            ItemIDTextBox.Text = "";
            MoneyTextBox.Text = "";
            TotalMoney = 0;
            CartCheckListBox.Items.Clear();
        }
        int HistoryFlag = 1;
        private void MoneyFinishButton_Click(object sender, EventArgs e)
        {
            AccountPanel.Visible = true;
            HistoryDisplayContent.Items.AddRange(File.ReadAllLines("E:\\CS511\\example\\shopping_with_no_sql_original\\Resources\\Hóa đơn\\Mã hóa đơn.txt"));
        }
        private void HistoryDisplayContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(HistoryFlag)
            {
                case 1:
                    DeleteHistoryButton.Visible = false;
                    HistoryDisplayContent.Items.Clear();
                    HistoryDisplayContent.Items.AddRange(File.ReadAllLines("E:\\CS511\\example\\shopping_with_no_sql_original\\Resources\\Hóa đơn\\Mã hóa đơn.txt"));
                    string SelectedFile = HistoryDisplayContent.GetItemText(HistoryDisplayContent.Text);
                    string tmp = @"E:\\CS511\\example\\shopping_with_no_sql_original\\Resources\\Hóa đơn\\" + SelectedFile;
                    var tmpFile1 = File.ReadAllText(tmp);
                    MessageBox.Show(tmpFile1);
                    if (File.Exists(tmp))
                    {
                        var tmp1 = File.ReadAllText(tmp);
                        HistoryDisplayTextBox.Text = tmp1;
                    }
                    break;
                case 2:
                    DeleteHistoryButton.Visible = true;
                    string SelectedFile1 = HistoryDisplayContent.GetItemText(HistoryDisplayContent.Text);
                    //string tmp2 = @"E:\\CS511\\example\\shopping_with_no_sql_original\\Resources\\Hóa đơn\\" + SelectedFile1;
                    //if (File.Exists(tmp2))
                    //{
                    //    string tmpPath = @"E:\CS511\example\shopping_with_no_sql_original\Resources\CancelRecord.txt";
                    //    File.AppendAllText(tmpPath, SelectedFile1);
                    //    File.Delete(tmp2);
                    //}
                    //var tmpFile2 = File.ReadAllText(tmp2);
                    //HistoryDisplayContent.Items.Clear();
                    //HistoryDisplayContent.Items.AddRange(File.ReadAllLines("E:\\CS511\\example\\shopping_with_no_sql_original\\Resources\\Hóa đơn\\Mã hóa đơn.txt"));
                    break;
            }
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            HistoryFlag = 1;
            SecondHistoryPanel.Visible = false;
            DeleteHistoryButton.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            HistoryFlag = 2;
            SecondHistoryPanel.Visible = false;
            DeleteHistoryButton.Visible = true;
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            DeleteHistoryButton.Visible = false;
            HistoryDisplayTextBox.Text = String.Empty;
            SecondHistoryPanel.Visible = true;
            var tmp3 = File.ReadAllText("E:\\CS511\\example\\shopping_with_no_sql_original\\Resources\\ViewFileRecord.txt");
            SecondHistoryTextBox.Text = tmp3;
            MessageBox.Show(tmp3);
        }

        private void HistorySeconExitButton_Click(object sender, EventArgs e)
        {
            SecondHistoryPanel.Visible=false;
        }

        private void DeleteHistoryButton_Click(object sender, EventArgs e)
        {
            string MaHoaDonpath = @"E:\\CS511\\example\\shopping_with_no_sql_original\\Resources\\Hóa đơn\\Mã hóa đơn.txt";
            string SelectedFile1 = HistoryDisplayContent.GetItemText(HistoryDisplayContent.Text);
            string tmp2 = @"E:\\CS511\\example\\shopping_with_no_sql_original\\Resources\\Hóa đơn\\" + SelectedFile1;
            if (File.Exists(tmp2))
            {
                CustomDeleteLineFromTextFile(MaHoaDonpath, SelectedFile1);
                string tmpPath = @"E:\CS511\example\shopping_with_no_sql_original\Resources\CancelRecord.txt";
                File.AppendAllText(tmpPath, SelectedFile1 + "\n");
                File.Delete(tmp2);
                HistoryDisplayContent.Items.Clear();
                HistoryDisplayContent.Items.AddRange(File.ReadAllLines("E:\\CS511\\example\\shopping_with_no_sql_original\\Resources\\Hóa đơn\\Mã hóa đơn.txt"));
                var a = File.ReadAllText(@"E:\CS511\example\shopping_with_no_sql_original\Resources\CancelRecord.txt");
                MessageBox.Show(a);
            }
        }
    }
}