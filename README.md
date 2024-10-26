# C# Programı: Bilgi Yarışması

Bu C# programı, kullanıcıya üç soru sorarak bir bilgi yarışması deneyimi sunmaktadır. Kullanıcı doğru cevaplar vererek büyük ödül kazanma şansını elde eder.

## Özellikler

1. **Soru 1**: Kızınca tüküren hayvan hangisidir?
   - a) Lama
   - b) Deve

2. **Soru 2**: Dünya'ya en yakın gezegen hangisidir?
   - a) Venüs
   - b) Mars

3. **Soru 3**: Aşağıdaki matematik işleminin sonucu nedir?
   - 5 * 2 + 8 / 2 - 2
   - a) 7
   - b) 12

## Program Akışı

- Kullanıcıdan cevaplar alınır ve her doğru cevap için `correctAnswers` sayacı artırılır.
- İlk iki sorudan en az biri yanlışsa, üçüncü soru sorulmaz ve kullanıcıya büyük ödül kazanma şansı kalmadığı bildirilir.
- Üçüncü soruya doğru cevap verilirse, kullanıcıya 1 Milyon TL'lik büyük ödül kazandığı bildirilir.

## Kod Açıklaması

### Ana Metod

```csharp
static void Main()
{
    int correctAnswers = 0;

    // Soru 1
    // ...
    // Soru 2
    // ...
    // Soru 3
    // ...
}

*correctAnswers değişkeni, doğru cevap sayısını tutar.
*Her soru için kullanıcıdan cevap alınır ve doğru cevap kontrol edilir.

### Soru Kontrolleri
Her soru için kullanıcıdan alınan cevaplar kontrol edilir ve doğru veya yanlış olduğu bildirilir. Yanlış cevap durumunda doğru cevap gösterilir.

### Sonuç
Kullanıcının doğru cevap sayısına göre sonuçlar belirlenir:

Eğer doğru cevap sayısı 2 veya daha fazlaysa, kullanıcı büyük ödülü kazanır.
Aksi takdirde, kullanıcıya büyük ödül kazanma şansı kalmadığı bildirilir.

### Kullanım
Programı çalıştırmak için bir C# geliştirme ortamında derleyip çalıştırabilirsiniz. Kullanıcıdan alınan cevaplar doğrultusunda sonuçlar konsolda gösterilecektir.

### Örnek Çıktı

1 -> Kızınca tüküren hayvan hangisidir?
a) Lama
b) Deve
a
Doğru!
2 -> Dünya'ya en yakın gezegen hangisidir?
a) Venüs
b) Mars
a
Doğru!
3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?
a) 7
b) 12
b
Doğru!
Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!

## Lisans

Bu taslağı projenizin ihtiyaçlarına göre özelleştirebilirsiniz. Başka bir konuda yardıma ihtiyacınız olursa, lütfen bana bildirin!

