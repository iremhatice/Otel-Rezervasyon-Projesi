Projem, kullanıcıların bir otel üzerinde online olarak rezervasyon yapabildiği, admin tarafında bu rezervasyonların karşılandığı, kullanıcının rezervasyonlarının onaylanması durumunda kendisine mail gönderildiği, kullanıcının arama kriterlerine göre rezervasyon yapabildiği bir akış üzerine kuruludur.
AspNet Core Api üzerinden Swagger ve Postman kullanarak testlerimi gerçekleştirdim.
Mimari olarak N Tier Architecture kullandım. Projede tek Solution altında 6 tane katman yer aldı. Entity Framework'ü kullandım.
Veri tabanı olarak MSSQL kullandım.
Proje güvenliği için Identity kullandım. Böylece yetkisiz rol erişimlerinin önüne geçmiş oldum.
Ek olarak projenin belli bir bölümünden sonra farklı api kaynaklarını tüketmeye başladım. Bunlar arasında en yoğun kullandığım Rapid Api oldu. 
Rapid Api üzerinden BookingCom apisini kullanarak kendi panelimiz üzerinden parametre girerek Booking'de otel verisi sonuçlarını kendi AspNet Core projeme taşıdım.
Yine Rapid Api üzerinden online otel rezervasyonlarında ihtiyaç olacağını düşündüğümüz "Uçuş, Döviz ve Hava Durumu" verilerini api olarak çekip consume ettim.
Finale gelirken Rapid Api üzerinden istediğim kullanıcıya ait Linkedin, Instagram, Twitter ve Facebook gibi platformlardan takipçi ve takip edilen kişi sayılarını çektim.

![giris](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/ec333482-f808-4bbb-a48e-98e364f145ad)
![kayit](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/0472e84e-6d75-4bc5-ab12-bc8130058543)
![hotelıer](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/dfaaf6d2-cc4c-4d26-9996-d69e6c43634d)
![hakkımzda](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/1fc7a0cb-bddc-402c-bfe4-e18e974bef0c)
![oda](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/ede1d22a-f499-42e7-b944-a397e2f59df8)
![oda2](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/cd970980-cae0-4403-b605-ade35b896882)
![hizmetler](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/07a75253-c64c-49e7-b7d1-265aa04aef36)
![ekip](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/e7060197-55f6-45de-870c-da2ad01d7ca9)
![footer](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/65ce926c-de1c-4052-8e89-bdfe21cdfa6d)
![rezervasyon2](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/3f3cc798-6b2f-4a7d-8b3f-d38b66c0fcef)
![iletişm](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/96e78ab2-1764-4fe0-8835-e1c8e2108854)
![dashboard](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/405cbc04-79ce-4e53-b708-476662bc6523)
![rezervasyon](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/1b2b3d02-2d72-4a27-a5c9-297b92ea892c)
![personel](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/7a0df7ca-fb17-4556-b37a-17635a8b8af9)
![personel2](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/e4066746-ad25-4599-8e5a-31bb1997d2a5)
![hizmet](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/da93f157-7566-4b90-b304-d88eb0d4764e)
![odalar](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/7c8b0824-cd84-4af8-9305-1acd531d0db3)
![mesaj](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/0b759cd2-fc88-4fd7-a606-cb74e3ea46fe)
![mail](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/0bfaf46d-7136-4346-834f-df08d3a5029c)
![kullanıcılar](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/27b922b3-f9d9-4695-8048-f08e42e29c97)
![lokasyon](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/7a89e582-5731-4792-9051-20b73c8d7b60)
![rol](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/39e1e2ec-6029-4f8c-bf35-a1d874c57f0e)
![rolata](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/994b5fff-c711-44ab-9482-4d7f4503d42d)
![rolata2](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/a264990c-1a5a-4034-8db0-0efe16353110)
![profilguncelle](https://github.com/iremhatice/Otel-Rezervasyon-Projesi/assets/140323451/1e8d344c-f660-43b6-8247-4baf92342825)

