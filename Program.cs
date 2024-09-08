// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Ekrana bir yazı yazınız");
string metin = Console.ReadLine();

// Ekrandan küçük harf aldığımız değeri,ekrana büyük harf olarak yazdıralım.(toUpper)
//metin = metin.ToUpper();
//Console.WriteLine(metin);

// ekrandan aldığımız büyük harfleri, küçük harfe çevirelim (toLower)
//metin =metin.ToLower();
//Console.WriteLine(metin);

// ekrandan aldğınız değer içerisindeki karakteri değiştirmek için kullanılır.(Replace)
//metin=metin.Replace("x"," ");
//Console.WriteLine(metin);

// çoklu kullanım için, peşpeşe replace fonksiyonunu çalıştırmanız gerekmektedir.(Length)

// ekrandan aldığımız değerin kaç karakter olduğunu öğrenelim
//Console.WriteLine("Girdiğiniz yazılının karakter uzunluğu : "+metin.Length);

#region Contains Uygulaması

// Contains, bir metnin içerisinde, bir karakterin olup olmadığını size söyleyen bir fonksiyondur.
// 
//bool isContains = metin.Contains("a");
//Console.WriteLine(isContains);
#endregion


#region  StartWith Uygulaması
// StartWith, bir metnin hangi harf ile başladığını kontrol etmek için kullanılır. 
// Büyük küçük harf duyarlıdır.
// sadece tek harf değil, çoklu harf kullanımıda destekler.

//bool isStartWith = metin.StartsWith("a");
//Console.WriteLine(isStartWith);    
#endregion

#region EndWith

//bool isEndWith=metin.EndsWith("n");
//Console.WriteLine(isEndWith);
#endregion

#region LastIndexOf

// LastIndexOf fonksiyonu, bir metin içerisinde bir harf'in, son index numarasını verir(Index numaraları diziler konusunda konuşulacak.)
// aranan değer, metin içerisinde yoksa sonuç -1 olacaktır.
// LastIndexOf içerisinde çoklu karaterde girebiliriz. Çoklu karakter girdiğinmizde, metin içierisinde bu karakterlin bulunduğu ilk index yazılacaktır.

//int isLastIndex = metin.LastIndexOf("arab");
//Console.WriteLine(isLastIndex);
//araba
#endregion

#region Insert
//Bir metnin içerisinde, istenilen başka bir metni yada harfi eklemek için kullanılır.
//string isInsert = metin.Insert(1,"wissen");
//Console.WriteLine(isInsert);

#endregion
// PadLeft : sizden aldığı bir metni, istenilen karakter kadar, verilen uzunluğa göre artırır.
//string isPadLeft=metin.PadLeft(20,'x');
//Console.WriteLine(isPadLeft);

#region
//Yukarıdaki fonksiyonun sonuna ekleyecek şekilde çalışır.
//string isPadRight=metin.PadRight(40,'0');
//Console.WriteLine(isPadRight);
#endregion

#region Remove
//Remove Fonksiyonu, bir metnin, istenilen indexden itibaren siler.
//string isRemove = metin.Remove(5);
//Console.WriteLine(isRemove);
#endregion

#region SubString

// SubString, bir metnin içerisindeki bir bölümü almak için kullanılır. Sizden iki paramtre ister, birincisi hangi indexden başlayacağı ve metnin ne kadarlık kısmını alacağıdır.
//string isSubString = metin.Substring(7,20);
//Console.WriteLine(isSubString); 


#endregion

#region Trim
//trim bir metnin baştaki ve sondaki,boşlukları temizlemek için kullanılır.(Sadece baştaki boşkluğu temizlemek için TrimStart, sondaki boşluğu temizlemek için TrimEnd kullanılır.)
//Aynı zamanda, trim fonksiyonu içerisinde bir karakter girerek, o karakterin temizlenmesini de sağlayabilirsiniz.
string isTrim = metin.Trim();
Console.WriteLine(isTrim);
#endregion

