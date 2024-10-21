
/*
1 - Aşağıdaki çıktıyı yazan bir program.
 Merhaba
 Nasılsın ?
 İyiyim
 Sen nasılsın ?


Console.WriteLine("Merhaba");
Console.WriteLine("Nasılsın");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen nasılsın");
*/

/*
 2 - Bir adet metinsel, bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp, ekrana yazdırınız. 

string metin = "Patika+ ailesine hoşgeldiniz";
int tamSayi = 12345;

Console.WriteLine("Metinsel Veri: " + metin);
Console.WriteLine("Tam Sayı: " + tamSayi);  
*/


/*
 3 - Rastgele bir sayı üretip ekrana yazdırınız.


Random rnd = new Random();
int randomSayi = rnd.Next(0, 101);

Console.WriteLine("Rastgele Sayı: " +  randomSayi);

*/


/*
 4 - Rastgele  bir sayı üretip, bunun 3'e bölümünden kalanı yazdırınız.


Random rnd = new Random();
int randomSayi = rnd.Next(0, 101);
int remander = randomSayi % 3;

Console.WriteLine("Rastgele üretilen sayı: " + randomSayi);
Console.WriteLine("3'e bölümünden kalan: " +  remander);
*/



/*
5 - Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.


Console.WriteLine("Lütfen yaşınızı giriniz.");
int yas = Convert.ToInt32(Console.ReadLine());
if (yas >= 18)
{
    Console.WriteLine("+");
}
else
{

Console.WriteLine("-"); 
}
*/




/*
6 - Ekrana 10 defa "Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.


int i = 1;
while (i < 11)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
    i++;
}
*/




/*
7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel", "Demet Evgar", bunların yerlerini değiştiriniz


Console.WriteLine("Lütfen 1. ünlü kadın oyuncunun ismini giriniz");
string kisi1 = Convert.ToString(Console.ReadLine());

Console.WriteLine("Lütfen 2. ünlü kadın oyuncunun ismini giriniz");
string kisi2 = Convert.ToString(Console.ReadLine());

Console.WriteLine("----- İlk Durum ----- ");
Console.WriteLine("1. Kişi --> " + kisi1);
Console.WriteLine("2. Kişi --> " + kisi2);

KisiDegistir(ref kisi1, ref kisi2);

Console.WriteLine("----- Son Durum -----");
Console.WriteLine("1. Kişi --> " + kisi1);
Console.WriteLine("2. Kişi --> " + kisi2);


void KisiDegistir(ref string k1, ref string k2)
{
    string gecici = k1;
    k1 = k2;
    k2 = gecici;
}
*/



/*
8 -  Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.


void BenDegerDondurmem()
{

    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");

}

BenDegerDondurmem();
BenDegerDondurmem();
BenDegerDondurmem();
BenDegerDondurmem();
BenDegerDondurmem();
BenDegerDondurmem();
*/



/*
9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.


using System;

int sayi1  = 10;
int sayi2 = 20;
int toplam = Topla(sayi1, sayi2);

Console.WriteLine("Toplam: " + toplam);

int Topla(int a, int b)
{

return a + b; 
}
*/



/*
10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.


Console.WriteLine("Lütfen 'true' ya da 'false' giriniz.");
bool kullaniciDegeri = Convert.ToBoolean(Console.ReadLine());

string sonuc = DegeriKontrolEt(kullaniciDegeri);
Console.WriteLine("Sonuç: " + sonuc);

static string DegeriKontrolEt(bool deger)
{
    if (deger)
    {
        return "Doğru değer girdiniz.";
    }
    else
    {
        return "Yanlış değer girdiniz.";
    }
}
*/




/*
11 - 3 kişinin yaşlarını alıp en yaşlı olanın yaş bilgisini dönen bir metot yazınız.


Console.WriteLine("Lütfen 1. kişinin yaşını giriniz.");
int yas1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen 2. kişinin yaşını giriniz.");
int yas2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen 3. kişinin yaşını giriniz.");
int yas3  = Convert.ToInt32(Console.ReadLine());

int enYasliYas = EnYasliKisiYasi(yas1, yas2, yas3);
Console.WriteLine("En yaşlı kişinin yaşı: " +  enYasliYas);


static int EnYasliKisiYasi(int yas1, int yas2, int yas3)
{
    int enYasli = yas1;
    if(yas2 > enYasli)
    {
        enYasli = yas2;
    }

    if(yas3 > enYasli)
    {
        enYasli = yas3;
    }
    return enYasli;
}
*/



/*
12 - Kullanıcıdan sınırsız sayıda sayı alıp, bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazdırınız.


List<int> sayilar = new List<int>();
string girdi;

Console.WriteLine("Sayıları girin (Çıkmak için 'exit' yazın.)");

while (true)
{
    girdi = Console.ReadLine();

    if (girdi.ToLower() == "exit")
    {
        break;
    }

    if(int.TryParse(girdi, out int sayi))
    {
        sayilar.Add(sayi);
    }
    else
    {
        Console.WriteLine("Lütfen geçerli bir sayi giriniz.");
    }
}

if (sayilar.Count > 0)
{
    int enBuyukSayi = EnBuyukSayiyiBul(sayilar);
    Console.WriteLine("Girilen sayılar arasında en büyük: " + enBuyukSayi);
}
else
{
    Console.WriteLine("Hiçbir sayı girilmedi");

}

static int EnBuyukSayiyiBul(List<int> sayilar)
{
    int enBuyuk = sayilar[0];

    foreach(int sayi in sayilar)
    {
        if (sayi > enBuyuk)
        {
            enBuyuk = sayi;
        }
    }
    return enBuyuk;
}
*/




/*
13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.


Console.WriteLine("Lütfen 1. ismi giriniz.");
string firstName  = Console.ReadLine();

Console.WriteLine("Lütfen 2. ismi giriniz.");
string secondName  = Console.ReadLine();

Console.WriteLine("----- İlk Durum -----");
Console.WriteLine("1. İsim --> " + firstName);
Console.WriteLine("2. İsim --> " +  secondName);
IsimDegistir(ref firstName, ref secondName);

Console.WriteLine("----- Son Durum -----");
Console.WriteLine("1. İsim --> " + firstName);
Console.WriteLine("2. İsim --> " + secondName);

void IsimDegistir(ref string firstName, ref string secondName)
{
    string gecici = firstName;
    firstName = secondName;
    secondName = gecici;
}
*/




//14 - Kullanıcıdan alınan sayının tek mi çift mi olduğu bilgisini (true/false) dönen bir metot.


// Kullanıcıdan bir sayı alınır
Console.Write("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

// Sayının tek mi çift mi olduğunu kontrol eden metot çağrılır
bool sonuc = TekMi(sayi);

// Sonuç kullanıcıya gösterilir
if (sonuc)
{
    Console.WriteLine("Sayı tektir.");
}
else
{
    Console.WriteLine("Sayı çifttir.");
}


// Sayının tek mi çift mi olduğunu kontrol eden metot
bool TekMi(int sayi)
{
    return sayi % 2 != 0; // Kalan 0 değilse tek sayıdır
}







/*
15 - Kullanıcıdan alınan hız ve zaman bilgileriyle, gidilen yolu hesaplayan bir metot yazdırınız 


Console.WriteLine("Lütfen hız değerini giriniz (km/h): ");
double hiz = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Lütfen zaman değerini giriniz (hour): ");
double zaman = Convert.ToDouble(Console.ReadLine());

double yol = GidilenYol(hiz, zaman);

Console.WriteLine("Gidilen yol: " + yol + " km");
double GidilenYol(double hiz, double zaman)
{

    {

        return hiz * zaman; // Yol = Hız * Zaman
    }
}

*/





/*
16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazdırınız.




void DaireninAlani()
{
    Console.WriteLine("Yarıçap giriniz:");
    double r = Convert.ToDouble(Console.ReadLine());

    double pi = 3.14;
   
    double daireAlani = r * r * pi;
    Console.WriteLine("Dairenin alanı:" + daireAlani);
}
DaireninAlani();
*/







/*
17 - "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harle yazdırınız.




string orijinalCümle = "Zaman bir GeRi SayIm";

// Hepsini büyük harfe çevirme
string büyükHarfCümle = orijinalCümle.ToUpper();
Console.WriteLine("Büyük Harf: " + büyükHarfCümle);

// Hepsini küçük harfe çevirme
string küçükHarfCümle = orijinalCümle.ToLower();
Console.WriteLine("Küçük Harf: " + küçükHarfCümle);

*/





/*
18 - "  Selamlar  " metnini bir değişkene atayıp, başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.


string kelime = "  Selamlar  ";

kelime = kelime.Trim();

Console.WriteLine(kelime);
*/
