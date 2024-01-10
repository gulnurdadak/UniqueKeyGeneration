# UniqueKeyGeneration

Bu proje, .NET Framework 4.7.2 kullanılarak yazılmıştır ve benzersiz anahtar üretmek için basit bir C# programı-algoritması içerir. Her bir benzersiz anahtar, belirli bir uzunluktaki karakter kümesinden rastgele karakterlerle oluşturulur.

## Nasıl Çalışır

Program, `GenerateUniqueCode` metodunu kullanarak belirli bir uzunluktaki benzersiz anahtarları oluşturur. Bu metod, kriptografik olarak güvenli rastgele sayılar sağlayan `RNGCryptoServiceProvider` sınıfını kullanır. Bu rastgele sayılar, önceden tanımlı bir karakter kümesinden seçilen karakterlerle birleştirilerek benzersiz anahtarlar oluşturur.

## Proje Yapısı

- `Program.cs`: Ana program dosyası. Kodun çalıştırılması ve benzersiz anahtarların oluşturulması burada gerçekleştirilir.
- `UniqueKeyGeneration.csproj`: C# proje dosyası.
  
## Nasıl Kullanılır

1. Projeyi bilgisayarınıza klonlayın veya ZIP dosyası olarak indirin.
2. Proje dosyalarını bir C# IDE'sinde (örneğin, Visual Studio) açın.
3. `.NET Framework 4.7.2` olarak hedeflenmiş olduğunu kontrol edin.
4. `Program.cs` dosyasını inceleyerek benzersiz anahtarların nasıl oluşturulduğunu gözlemleyin.
5. Projeyi çalıştırarak ve yorum satırına alınmış (Console.ReadKey()) satırını açarak konsol ekranında üretilen benzersiz anahtarları gözlemleyebilirsiniz.

## Önemli Notlar

- Bu program .NET Framework 4.7.2 ile yazılmıştır. Farklı bir .NET sürümü kullanıyorsanız, projeyi uygun bir sürüme güncellemeniz gerekebilir.
- Bu programın amacı, basit ve güvenli bir algoritma örneği oluşturmaktır. Gerçek uygulamalarda daha karmaşık güvenlik önlemleri gerekebilir.

