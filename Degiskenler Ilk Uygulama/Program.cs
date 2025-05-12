Console.WriteLine("Lutfen asagidaki bilgileri giriniz");

Console.Write("T.C. Kimlik Numarasi:");
string tc = Console.ReadLine();

Console.Write("Adi:");
string name = Console.ReadLine();

Console.Write("Soyadi:");
string surname = Console.ReadLine();

Console.Write("Telefon numarasi:");
string phone = Console.ReadLine();
// Telefon numarasi matematiksel islemde kullanilmaz

Console.Write("Yas:");
int age;
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Ilk aldigi urunun fiyati:");
double price1;
price1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ikinci aldigi urunun fiyati:");
double price2;
price2 = Convert.ToDouble(Console.ReadLine());

double total = price1 + price2;
double reward = total * 0.10;
// Urunun fiyati ve 10%'u ondalikli olabilecegi icin double kullandim


Console.WriteLine("-----------------------------------------");

Console.WriteLine(tc + " Tc numarali " + name + " isimli kisi icin kayit olusturulmustur.");
Console.WriteLine(phone + " telefon numarasina bildirim mesaji gonderilmistir.");
Console.WriteLine(total + " TL toplam harcama karsiligi kazanilan 10% patika puan miktari -> " + reward + " TL'dir ");