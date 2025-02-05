
# Bogus Kütüphanesi ile Sahte Kullanıcı Verisi Üretme

Bu demo, .NET ekosisteminde test süreçlerini iyileştirmek için `Bogus` kütüphanesini kullanarak sahte kullanıcı verileri üretmeyi amaçlamaktadır. Bu repo, iki farklı yaklaşımı incelemektedir:
- Statik metod ile sahte veri üretme
- `Faker` sınıfından türetilmiş bir alt sınıf ile sahte veri üretme

Her iki yaklaşımın avantajlarını inceleyecek ve hangi durumlarda hangi yöntemin kullanılmasının daha uygun olacağını tartışacağız.

## İçindekiler
- [Proje Hakkında](#proje-hakkında)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Yaklaşımlar](#yaklaşımlar)
- [Katkı](#katkı)
- [Lisans](#lisans)

## Proje Hakkında

Gerçek verilerle test yapmak çoğu zaman güvenlik, gizlilik ve erişilebilirlik sorunlarına yol açabilir. Bu nedenle, sahte ancak gerçekçi görünen veriler üretmek yazılım projelerinde oldukça önemlidir. Bu proje, `Bogus` kütüphanesini kullanarak sahte kullanıcı verileri üretmek için iki farklı yaklaşımı incelemektedir.

## Kurulum

Projeyi başlatmadan önce `Bogus` kütüphanesinin kurulması gerekmektedir. Projenizde `Bogus` kütüphanesini yüklemek için aşağıdaki komutlardan birini kullanabilirsiniz:

- **NuGet Package Manager Console**:
  ```bash
  Install-Package Bogus
  ```

- **.NET CLI**:
  ```bash
  dotnet add package Bogus
  ```

## Kullanım

Projenizi kurduktan sonra `Program.cs` dosyasındaki iki farklı yöntemi kullanarak sahte kullanıcı verisi üretebilirsiniz.

### Statik Metod ile Kullanıcı Verisi Üretme

Bu yöntem, sahte kullanıcı verilerini hızlıca oluşturmak için uygun ve basittir. Kodda aşağıdaki gibi kullanabilirsiniz:

```csharp
var generatorStatic = BogusUserGenerator.CreateFaker();
var usersStatic = generatorStatic.Generate(10);
```

### Faker Sınıfından Türetilmiş Alt Sınıf Kullanarak Veri Üretme

Bu yöntem, daha geniş projelerde daha modüler ve yeniden kullanılabilir bir yapı sağlar. Kodda şu şekilde kullanabilirsiniz:

```csharp
var generatorSubclass = new UserGenerator();
var usersSubclass = generatorSubclass.Generate(10);
```

Her iki yöntemi de kullanarak sahte kullanıcılar üretebilir ve sonuçları konsola yazdırabilirsiniz.

## Yaklaşımlar

### Statik Metod Kullanımı
- **Avantajları**: Hızlı ve basit veri üretimi, tek seferlik kullanımlar için idealdir.
- **Kullanım Senaryosu**: Küçük projeler veya tek seferlik veri üretimi.

### Faker Alt Sınıfı Kullanımı
- **Avantajları**: Daha modüler, yeniden kullanılabilir ve genişletilebilir yapı.
- **Kullanım Senaryosu**: Büyük projeler, testler veya modüler yapı gereksinimleri.

## Katkı

Katkı yapmak isterseniz, lütfen şu adımları takip edin:
1. Bu projeyi çatallayın (fork).
2. Yeni bir özellik dalı oluşturun (`git checkout -b feature-xyz`).
3. Değişikliklerinizi kaydedin (`git commit -am 'Add new feature'`).
4. Dalınızı gönderin (`git push origin feature-xyz`).
5. Bir pull request açın.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır - ayrıntılar için [LICENSE.md](LICENSE.md) dosyasına bakabilirsiniz.
