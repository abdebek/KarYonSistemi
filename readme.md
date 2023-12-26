# KarYönSistemi: Kargo Yönetim Sistemi

Bir kargo/gönderi yönetim sistemi oluşturulması istenmektedir. BUygulamanın aşağıdaki
özellikleri içermesi gerekmektedir:

GonderiYonetimSistemi

- **Ivarlık:** SeriNo (Seri Numarası) ve Silinmis (Silinmiş mi) gibi özellikleri tanımalar.
- **IKargo:** Ivarlık sınıfından kalıtım almalı ve Adi, TelNumarasi ve Adres gibi fazla özellikleri tanımalamalı.
- IGonderiHizmetSaglayicisi: KargoGonder ve GonderiSurecleriniYonet gibi metotları tanımlar.

sealed sınıf: GonderiHizmetSaglayicisi GonderiHizmetSaglayicisi sınıftan kalıtım alır
/// Dolayısıyla, IGonderiHizmetSaglayicisi, IKargo and IVarlık interface'lerini de uygulamış (implement etmiş) olur.

ArasKargo : GonderiHizmetSaglayicisi

PTTKargo : GonderiHizmetSaglayicisi

YurticiKargo : GonderiHizmetSaglayicisi

Icon: `[Truck icons created by DinosoftLabs - Flaticon](`https://www.flaticon.com/free-icons/truck `)`
