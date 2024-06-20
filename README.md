# E Arşiv Portal
### Proje Açıklaması
Bu projede, admin, user ve test girişleri mevcuttur. Kayıt ol sayfasından kayıt olunduğunda user rolünde kayıt olursunuz. 
Ve eğer kayıt olmadan giriş yapmak istiyorsanız giriş yap sayfasından kullanıcı öner butonuna tıklayarak gelen bilgiler ile giriş yapabilirsiniz.
Admin veya User olarak giriş yaparsanız;
+	Admin ve user girişlerinde sağ üst kısımda profil düzenleme sayfası bulunmaktadır. Burada isim, email, telefon numarası, şifre gibi bilgiler güncellenebilir, profil fotoğrafı eklenip güncellenebilir.
+	İki Faktörlü Kimlik Doğrulama kısmından kimlik doğrulayıcı ekleme seçeneği ile Google Authenticator kullanarak hesabınıza İki Faktörlü Kimlik Doğrulama ekleyebilirsiniz.

Bu seçenekler test girişinde bulunmamaktadır. 

User veya test girişi yaptığınızda; belgeler sayfasına girdiğinizde belgeleri içeren bir tablo göreceksiniz. 
+	Tabloda isim ile arama ve sayfadaki kayıt sayısı seçimi yapabilirsiniz.
+	Başlangıç ve bitiş tarihlerini seçerek o tarihler aralığında düzenlenen belgeleri sorgulayabilirsiniz.
+	Belge Numarasına tıklayarak belgenin detaylarına ulaşabilir, PDF olarak indirebilir ve yazdırabilirsiniz.

Admin girişi yaptığınızda; 
+	User veya test girişindeki uygulamalara ek olarak tablodaki sil butonunu kullanarak belge silebilirsiniz.
+	Belge ekle sayfasına girerek yeni belge oluşturabilirsiniz.

Uygulama sizi oturum açıldıktan 20 dakika sonra otomatik olarak atar. Uygulama responsive tasarlanmıştır. 

### Kullanılan Teknolojiler
+	Microsoft SQL Server
+	ASP.NET Core MVC (.NET 7.0)
+	Asp.Net Core Identity
+	RESTful APİ
+	Generic Repository pattern
+	HTML, CSS, Bootstrap
+	JavaScript, jQuery
+	AJAX
+	DataTable
+	html2pdf

  ### Kurulum Talimatları
1.	Depoyu Klonlayın:
Terminal veya komut istemcisini açın ve aşağıdaki komutu çalıştırın:          
```bash
git clone https://github.com/elifsudekvc/EArsivPortal.git
```

2.	Visual Studio'yu açın.
File menüsünden Open -> Project/Solution seçeneğini tıklayın.
Klonladığınız EArsivPortal dizinine gidin ve EArsivPortal.sln dosyasını seçip açın.

3.	Bağımlılıkları Yükleyin:
```bash
dotnet restore
```
4.	Veritabanını Güncelleyin
appsettings.json dosyasında veritabanı ayarlarının doğru yapılandırıldığından emin olun. Daha sonra, veritabanı şemasını ayarlamak için bekleyen göçleri uygulayın:
```bash
dotnet ef database update
```

5.	Son olarak, projeyi çalıştırın:
```bash
dotnet run
```

###Ekran görüntüleri ve APİ çıktısı
![Ekran görüntüsü 2024-06-20 192320](https://github.com/elifsudekvc/EArsivPortal/assets/130573532/3dfa547a-c219-496e-aec4-87588ec84a65)
JSON bu şekildedir. Sadece giriş yapan kişiler tarafından görüntülenecek şekilde gizlenmiştir.

![Ekran görüntüsü 2024-06-20 194921](https://github.com/elifsudekvc/EArsivPortal/assets/130573532/432ee379-4389-4484-b2c3-3f185530b11f)

![Ekran görüntüsü 2024-06-20 195033](https://github.com/elifsudekvc/EArsivPortal/assets/130573532/13aee5d9-542d-4361-b32f-013449a663d4)
![Ekran görüntüsü 2024-06-20 195125](https://github.com/elifsudekvc/EArsivPortal/assets/130573532/a04aabf9-2e52-49a5-a8f3-8243372bf7d3)
![Ekran görüntüsü 2024-06-20 195213](https://github.com/elifsudekvc/EArsivPortal/assets/130573532/86137015-5d88-4f52-a822-9afe59db8186)
![Ekran görüntüsü 2024-06-20 195234](https://github.com/elifsudekvc/EArsivPortal/assets/130573532/0c4b224c-4b85-4979-b909-a9557777e4f1)
![Ekran görüntüsü 2024-06-20 195256](https://github.com/elifsudekvc/EArsivPortal/assets/130573532/0121e97e-7135-4b61-bc77-60e2b9b81761)
![Ekran görüntüsü 2024-06-20 195322](https://github.com/elifsudekvc/EArsivPortal/assets/130573532/d001bfb8-540f-4588-b6d0-b7fc8b74ee7b)
