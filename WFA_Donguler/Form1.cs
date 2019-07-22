using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //DONGULER - LOOPS
        //Bir baslangic degeri olan, belirli bir kosul gerceklesene dek suren ve bu surec icerisinde bir takim islemleri tekrarli olarak gerceklestiren nesnelere "dongu" adini vermekteyiz.
        //FOR - FOREACH - WHILE - DOWHILE
        private void BtnOrnekBir_Click(object sender, EventArgs e)
        {
            //Donguye ilk giris aninda derleyici baslangic degerine bakar ve bir daha asla bu bloga ugramaz. 
            //Bundan sonraki islemler once arttir, daha sonra kosula bak, kosul uygunsa dongunun kod blogunu harekete gecir, uygun degilse donguden cik...

            //for(BaslangicDegeri; BitisKosulu; Artis-AzalisMiktari)
            for (int deger = 1; deger <= 1000; deger++)
            {
                listBox1.Items.Add(deger);
            }
        }

        private void BtnOrnekIki_Click(object sender, EventArgs e)
        {

        }

        private void BtnOrnekUc_Click(object sender, EventArgs e)
        {

        }

        private void BtnOrnekDort_Click(object sender, EventArgs e)
        {

        }

        private void BtnOrnekBes_Click(object sender, EventArgs e)
        {
            //1-100 arasındaki sayilarin toplamini ekrana yazdiriniz..
        }

        private void BtnOrnekAlti_Click(object sender, EventArgs e)
        {
            //1-100 arasindaki cift sayilarin toplami ile, tek sayilarin toplaminin farklari karesi kactir?
        }

        private void BtnOrnekYedi_Click(object sender, EventArgs e)
        {
            //1945 - günümüz yılı arasındaki yıllar Listbox'a eklensin ancak 1990 ve 1992 yılları eklenmeyecek...
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide yer alan her bir elemani, listbox icerisine ekleyiniz...
            string[] takimlar = { "Galatasaray", "Fenerbahce", "Besiktas", "Trabzonspor", "Bursaspor", "Ankaragücü" };
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //Sayisal bir dizi tanimlayin ve Array sınıfını kullanmadan o dizinin en buyuk elemanini gosterin...
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6 };
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide kac tane cift kac tane tek sayi vardir kullaniciyi bilgilendiriniz..
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6, 25 };
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //asagidaki "adim" degiskeninde yer alan metni tersten isterseniz formun tepesine, isterseniz MessageBox'la yazdiriniz...

            //NOT => STRING'LER BİRER CHAR DİZİSİDİR...
            string adim = "bilgeadam";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Karmasik 10 adet sayiyi listbox icerisine ekleyiniz...
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Form uzerinde yer alan tum butonlarin arkaplan renkleri kırmızı, yazi renkleri ise sarı olsun...

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Disaridan girilen sayisal ifadenin rakam degerleri toplamini gosteriniz...
            //Ornegin 123 girilirse 1+2+3 = 6 sonucu donmelidir...
        }



        /*
   FOREACH
   1) Kesinlikle index mantigi yoktur!
   2) Tip bagimli dongulerdir...
   3) Cogu zaman elimizdeki bir koleksiyonun her bir elemanini tek tek ele almak icin kullanilir...
*/


        private void Button16_Click(object sender, EventArgs e)
        {
            //İlgili dizi icerisindeki her bir elemana gecici olarak "str" takma adi verilir ve dongunun her bir adiminda size dizinin her bir elemani teslim edilir...
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            //İkiye bolunenleri listbox1'e bolunemeyenleri listbox2 ye atın... Hem ikiye hem uce bolunenlerin kac tane oldugunu da messagebox'la gosterin...
            int[] dizi = { 123, 54, 76, 876, 4532, 23, 77, 734, 83, 45, 190 };
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            //Listbox1'deki secili tum elemanlari (birden fazla secim sansi olmali!) listbox2'ye ekleyelim...
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            //Form uzerindeki tum butonlarin arkaplanlari ve yazi renklerini degistiriniz...
        }
    }
}
