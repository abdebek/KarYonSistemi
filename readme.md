# KarYönSistemi: Kargo Yönetim Sistemi

Bir kargo/gönderi yönetim sistemi oluşturulması istenmektedir. BUygulamanın aşağıdaki
özellikleri içermesi gerekmektedir:

- **Ivarlık:** SeriNo (Seri Numarası) ve Silinmis (Silinmiş mi) gibi özellikleri tanımalar.
- **IKargo:** Ivarlık interface'nden kalıtım almalı. Adi, TelNumarasi ve Adres gibi fazla özellikleri tanımalamalı.
- **IGonderiHizmetSaglayicisi**: KargoGonder ve GonderiSurecleriniYonet gibi metotları tanımlar.
- **GonderiHizmetSaglayicisi:** GonderiHizmetSaglayicisi IGonderiHizmetSaglayicisi interface'nden kalıtım alır. Dolayısıyla, IGonderiHizmetSaglayicisi, IKargo and IVarlık interface'lerini de uygulamış (implement etmiş) olur. Kendisinden kalıtım alan sınıflar Adi, TelNumarasi ve Adres gibi özellikleri tanımlamak ve KargoGonder metodunu uygulamak zorunda kalmalı. TahminiBeklemeSuresi ve Silinmis özellikleri ve GonderiSurecleriniYonet metodu için ise isteğe bağlı oarak değişitirilebilir şeklinde uygulamalı veya tanımlama ypmalı. GonderiSurecleriniYonet metodu çağrıldığında içerisinde seçilmiş GonderiHizmetSaglayicisi'ne göre değişen süre sonra gönderinin durumu teslim edildi olarak güncellenmeli. Varsıyal TahminiBeklemeSuresi'ni bir dakika olarak belirlenmeli.
- **ArasKargo:** GonderiHizmetSaglayicisi sınıfından kalıtım alır. Kendisinden kalıtım alınmaması için gerekli erişim denetleyecileri kullanılmalı. Kendi TahminiBeklemeSuresi'ni tanımlamamalı ve kalıtım aldığı sınıfta tanımlanmış değeri kullanmalı.
- **PTTKargo:** GonderiHizmetSaglayicisi sınıfından kalıtım alır. Kendisinden kalıtım alınmaması için gerekli erişim denetleyecileri kullanılmalı. TahminiBeklemeSuresi'ni 5 saniye olarak ovveride etmeli. Ayrıca, GonderiSurecleriniYonet metodunu da override edip kendisi uygulamalı.
- **YurticiKargo:** GonderiHizmetSaglayicisi sınıfından kalıtım alır. Kendisinden kalıtım alınmaması için gerekli erişim denetleyecileri kullanılmalı. TahminiBeklemeSuresi'ni 10 saniye olarak ovveride etmeli.
- **IGonderiBilgi:** Ürün ve Gönderileri eklemek gönderilm ve mevcut ürünlerde ve gönderilerde aramalar yapmak ve kargo/gönderi işlemlerini başlatmak için kullanılacak metotları tanımlamaı.
- **GonderiYonetimSistemi:** IGonderiBilgi interface'nden kalıtım alır (tanımlanmış metotlarını uygular). İlk oluşturulduğunda TohumVerileri sınıfı kullanarak örnek veriler hazırlamalı.
- **TohumVerileri:** Örnek urunleri ve gönderileri oluşturmak için kullanılabilecek bir sınıf olmalı.
- **AnaForm:** GonderiYonetimSistemi sınıfını kullanarak Windows Forms tabanlı bir GUI üzerinden işlemleri yapmak için gerekli olan görsel tasarım içermeli.

### Sınıf Şekli (Class Diagram)):

![Classs Diagram](image\readme\cdiagram.png)

Uygulamada Kullanılmış Icon aşağıdaki adresten alınmıştır.

Icon: `[Truck icons created by DinosoftLabs - Flaticon](`https://www.flaticon.com/free-icons/truck `)`
