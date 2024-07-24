   using System.Threading.Channels;
using System.Xml;

// Kullanıcıya manavdaki fiyatların bilgisi verilir.

Console.WriteLine("Rüya Manavına Hoş Geldiniz.");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");

Console.WriteLine("");  // Boşluk satırı bıraktım.

Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");

string meyve = Console.ReadLine().ToLower();  // Sorduğum soruya kullanıcı cevap yazarken büyük/küçük harf yazımından dolayı hata vermesin diye tüm harfleri küçük harfe çeviren ''ToLower'' kullandım.


switch (meyve)  // Kullanıcının girdiği bilgiye göre verdiğim ''case''lerden biri çıktı olarak ekrana düşecek ve switch-case karar yapısından çıkış yapılacak.
{
    case "elma":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;
    default:
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
        break;
}

//  if-else kontrol yapısını da kullanıcının verdiği bilgiye göre çıktı alması için kullanıyoruz.
/*
if (meyve == "elma")
{
    Console.Write("Seçtiğiniz meyvenin fiyatı: 2 TL");
}

else if (meyve == "armut")
{
    Console.Write("Seçtiğiniz meyvenin fiyatı: 3 TL");
}

else if (meyve == "çilek")
{
    Console.Write("Seçtiğiniz meyvenin fiyatı: 2 TL");
}

else if (meyve == "muz")
{
    Console.Write("Seçtiğiniz meyvenin fiyatı: 3 TL");
}

else
{
    Console.Write("Seçtiğiniz meyvenin fiyatı: 4 TL");
}

Sadece eşitlik koşulu içeren bu tür kontrol yapılarında switch-case kullanımı daha yalın ve kolay olur. Çünkü if-else kullanılmasını gerektiren karmaşık koşullar bulunmamaktadır.
*/