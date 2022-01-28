# DorduncuHaftaOdevi
Tamamladığım projede Clean Architecture Mimarisi uygulanmaya çalışılmıştır.
EntityFramework ile Generic repository pattern ve unit of work kullanılmıştır.
Mapping işlemi Automapper eklentisi ile sağlanmıştır.
Bir adet User Class ı tanımlanarak <b>PostgreSql</b> Veritabanı üzerinde user table oluşturulmuştur.
Hangfire kullanılarak InsertData ve StatusChanger adında 2 adet job oluşturuldu.
 > <b>InsertData :</b> Bu job yardımı ile her 15 dakikada bir user datası random olarak sisteme kayıt edilir. 
  <br>
 > <b>StatusChanger :</b> Bu job yardımı ile o gün içinde 08:00 - 18:00 aralıgında oluşturulmuş user datalarının 
 > status propertyleri hergün saat 18:00 da false dan true ya çekilmiştir.
 > <br>
 > Swagger yardımı ile database deki verileri Get metodu ile çekerek kontrol edebilirsiniz.
 > Ayrıca hangfire verileri de PostgreSql veritabanında tutulmuştur.

[Odev 4.0..pdf](https://github.com/Semra4141/UcuncuHaftaOdevi/files/7918753/Odev.4.0.pdf)

## Hangfire Genel Tablo

<img src="" />

## Hangfire Başarılı işlemler Tablosu

<img src="" />

## Hangfire Tekrarlayan işlemler Tablosu

<img src="" />

## Hangfire 

<img src="" />

## Swagger 

<img src="" />

## Swagger with Data
 
<img src="" />


## PostgreSql Veritabanı

<img src="" />



