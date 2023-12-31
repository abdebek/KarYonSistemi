# KarYönSistemi: Kargo Yönetim Sistemi

> Bir kargo yönetim sistemi oluşturulması istenmektedir.

### Uygulamanın aşağıdaki özellikleri içermesi gerekmektedir:

- **IVarlik:** SeriNo (Seri Numarası) ve Silinmis (Silinmiş mi) gibi özellikleri tanımalar.
- **IKargo:** IVarlik interface'nden kalıtım almalı. Adi, TelNumarasi ve Adres gibi fazla özellikleri tanımalamalı.
- **Varlik:** IVarlik interface'nden kalıtım almalı. Ayrıca, SeriNo değeri olarak sıfırdan küçük bir rakam atanmamasını sağlamalı.
- **Urun:** Varlik sınıfından kalıtım alır. Ek olarak, Adi ve Fiyati diye 2 özellik daha tanımlamalı. Ayrıca, Urun Fiyati sıfırdan küçük olmamalı.
- **Gonderi:** Varlik sınıfından kalıtım alır. KargoNo değerinin sıfırdan küçük veya 2'den büyük olmasına izin vermemeli.
- **IGonderiHizmetSaglayicisi**: KargoGonder ve GonderiSurecleriniYonet gibi metotları tanımlar.
- **GonderiHizmetSaglayicisi:** GonderiHizmetSaglayicisi IGonderiHizmetSaglayicisi interface'nden kalıtım alır. Dolayısıyla, IGonderiHizmetSaglayicisi, IKargo and IVarlık interface'lerini de uygulamış (implement etmiş) olur. Kendisinden kalıtım alan sınıflar Adi, TelNumarasi ve Adres gibi özellikleri tanımlamak ve KargoGonder metodunu uygulamak zorunda kalmalı. TahminiBeklemeSuresi ve Silinmis özellikleri ve GonderiSurecleriniYonet metodu için ise isteğe bağlı oarak değişitirilebilir şeklinde uygulamalı veya tanımlama ypmalı. GonderiSurecleriniYonet metodu çağrıldığında içerisinde seçilmiş GonderiHizmetSaglayicisi'ne göre değişen süre sonra gönderinin durumu teslim edildi olarak güncellenmeli. Varsıyal TahminiBeklemeSuresi'ni bir dakika olarak belirlenmeli. Ayrıca, bu sınıftan bir nesne türetilememeli.
- **ArasKargo:** GonderiHizmetSaglayicisi sınıfından kalıtım alır. Kendisinden kalıtım alınmaması için gerekli erişim denetleyecileri kullanılmalı. Kendi TahminiBeklemeSuresi'ni tanımlamamalı ve kalıtım aldığı sınıfta tanımlanmış değeri kullanmalı.
- **PTTKargo:** GonderiHizmetSaglayicisi sınıfından kalıtım alır. Kendisinden kalıtım alınmaması için gerekli erişim denetleyecileri kullanılmalı. TahminiBeklemeSuresi'ni 5 saniye olarak ovveride etmeli. Ayrıca, GonderiSurecleriniYonet metodunu da override edip kendisi uygulamalı.
- **YurticiKargo:** GonderiHizmetSaglayicisi sınıfından kalıtım alır. Kendisinden kalıtım alınmaması için gerekli erişim denetleyecileri kullanılmalı. TahminiBeklemeSuresi'ni 10 saniye olarak ovveride etmeli.
- **IGonderiBilgi:** Ürün ve Gönderileri eklemek gönderilm ve mevcut ürünlerde ve gönderilerde aramalar yapmak ve kargo/gönderi işlemlerini başlatmak için kullanılacak metotları tanımlamaı.
- **GonderiYonetimSistemi:** IGonderiBilgi interface'nden kalıtım alır (tanımlanmış metotlarını uygular). İlk oluşturulduğunda TohumVerileri sınıfı kullanarak örnek veriler hazırlamalı.
- **TohumVerileri:** Örnek urunleri ve gönderileri oluşturmak için kullanılabilecek bir sınıf olmalı.
- **AnaForm:** GonderiYonetimSistemi sınıfını kullanarak Windows Forms tabanlı bir GUI üzerinden işlemleri yapmak için gerekli olan görsel tasarım içermeli.

### Sınıf Şekli (Class Diagram):

![Classs Diagram](KarYonSistemi/Assets/ClassDiagrams.png "Classs Diagram")

Uygulamada Kullanılmış Icon şu adresten alınmıştır: `[Truck icons created by DinosoftLabs - Flaticon](`https://www.flaticon.com/free-icons/truck `)`
