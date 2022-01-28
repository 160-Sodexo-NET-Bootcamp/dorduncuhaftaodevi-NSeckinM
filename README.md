# DorduncuHaftaOdevi
Tamamladığım projede Clean Architecture Mimarisi uygulanmaya çalışılmıştır.
EntityFramework ile Generic repository pattern ve unit of work kullanılmıştır.
Mapping işlemi Automapper eklentisi ile sağlanmıştır. <br>
Bir adet User Class ı tanımlanarak <b>PostgreSql</b> Veritabanı üzerinde user table oluşturulmuştur.
Hangfire kullanılarak InsertData ve StatusChanger adında 2 adet job oluşturulmuştur.<br>

<b>InsertData :</b> Bu job yardımı ile her 15 dakikada bir user datası random olarak sisteme kayıt edilir. 
<br>
<b>StatusChanger :</b> Bu job yardımı ile o gün içinde 08:00 - 18:00 aralıgında oluşturulmuş user datalarının status propertyleri hergün saat 18:00 da false dan true ya çekilmiştir.
<br>
Swagger yardımı ile database deki verileri Get metodu ile çekerek kontrol edebilirsiniz.
Ayrıca hangfire verileri de PostgreSql veritabanında tutulmuştur.

[Odev 4.0..pdf](https://github.com/Semra4141/UcuncuHaftaOdevi/files/7918753/Odev.4.0.pdf)

## Hangfire Genel Tablo

<img src="https://github.com/160-Sodexo-NET-Bootcamp/dorduncuhaftaodevi-NSeckinM/blob/main/NSeckinMantar_Odev4_BackgroundServices/Src/ApplicationCore/Images/Hangfire.png" />

## Hangfire Başarılı işlemler Tablosu

<img src="https://github.com/160-Sodexo-NET-Bootcamp/dorduncuhaftaodevi-NSeckinM/blob/main/NSeckinMantar_Odev4_BackgroundServices/Src/ApplicationCore/Images/HangBasarili.png" />

## Hangfire Tekrarlayan işlemler Tablosu

<img src="https://github.com/160-Sodexo-NET-Bootcamp/dorduncuhaftaodevi-NSeckinM/blob/main/NSeckinMantar_Odev4_BackgroundServices/Src/ApplicationCore/Images/HangTekrarlayan.png" />

## Hangfire 

<img src="https://github.com/160-Sodexo-NET-Bootcamp/dorduncuhaftaodevi-NSeckinM/blob/main/NSeckinMantar_Odev4_BackgroundServices/Src/ApplicationCore/Images/HangLog.png" />

## Swagger 

<img src="https://github.com/160-Sodexo-NET-Bootcamp/dorduncuhaftaodevi-NSeckinM/blob/main/NSeckinMantar_Odev4_BackgroundServices/Src/ApplicationCore/Images/swagger.png" />

## Swagger with Data
 
<img src="https://github.com/160-Sodexo-NET-Bootcamp/dorduncuhaftaodevi-NSeckinM/blob/main/NSeckinMantar_Odev4_BackgroundServices/Src/ApplicationCore/Images/swaggerData.png" />


## PostgreSql Veritabanı

<img src="https://github.com/160-Sodexo-NET-Bootcamp/dorduncuhaftaodevi-NSeckinM/blob/main/NSeckinMantar_Odev4_BackgroundServices/Src/ApplicationCore/Images/postgreSql.png" />



