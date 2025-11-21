# Digital Agency - Dijital Pazarlama Ajansı

Bu proje, dijital pazarlama şirketi için modern bir web sitesi ve admin paneli içermektedir.

## 📁 Proje Yapısı

```
digital-agency-frontend/
├── website/          # Next.js Web Sitesi (SEO Uyumlu)
├── admin-panel/      # React Admin Paneli
└── README.md        # Bu dosya
```

## 🌐 Web Sitesi (Next.js)

Modern, SEO uyumlu, yeşil tonlarında tasarlanmış dijital pazarlama web sitesi.

### Özellikler
- ✅ Next.js 15 ile SEO uyumlu yapı
- ✅ Tailwind CSS ile modern tasarım
- ✅ Responsive (mobil uyumlu) tasarım
- ✅ Hero slider animasyonları
- ✅ Dinamik sayfa yapısı
- ✅ Yeşil tonlarında profesyonel tema

### Sayfalar
- Ana Sayfa (Hero slider, hizmetler, istatistikler)
- Hakkımızda
- Hizmetlerimiz
- Referanslar
- Blog
- İletişim

### Kurulum ve Çalıştırma

```bash
# Website dizinine git
cd website

# Bağımlılıkları yükle
npm install

# Development modda çalıştır
npm run dev

# Production build
npm run build
npm start
```

Web sitesi: http://localhost:3000

## 🎨 Admin Paneli (React)

Yeşil tonlarında, modern ve kullanıcı dostu admin paneli.

### Özellikler
- ✅ React 18 ile modern yapı
- ✅ React Router ile sayfa yönlendirme
- ✅ Responsive sidebar menü
- ✅ Dashboard ile özet görünüm
- ✅ CRUD işlemleri için modal'lar
- ✅ Yeşil tonlarında tutarlı tasarım

### Sayfalar
- Dashboard (Özet görünüm, istatistikler)
- Sliderlar Yönetimi
- Hizmetler Yönetimi
- Bloglar Yönetimi
- Referanslar Yönetimi
- Mesajlar
- Ayarlar

### Kurulum ve Çalıştırma

```bash
# Admin-panel dizinine git
cd admin-panel

# Bağımlılıkları yükle
npm install

# Development modda çalıştır
npm start

# Production build
npm run build
```

Admin Paneli: http://localhost:3000

### Demo Giriş Bilgileri
```
E-posta: admin@digitalmarketing.com
Şifre: admin123
```

## 🎨 Renk Paleti

Projede kullanılan yeşil tonları:

```css
--primary: #10b981        /* Ana yeşil */
--primary-dark: #059669   /* Koyu yeşil */
--primary-light: #34d399  /* Açık yeşil */
--secondary: #14b8a6      /* Teal/Turkuaz */
```

## 🔧 Backend Entegrasyonu

Backend ASP.NET Core ile hazırlanacaktır. API endpoint'leri için:

### API URL'si (Settings'ten ayarlanabilir)
```
https://localhost:5001/api
```

### Gerekli Endpoint'ler

```
GET    /api/sliders          # Slider listesi
POST   /api/sliders          # Yeni slider
PUT    /api/sliders/{id}     # Slider güncelle
DELETE /api/sliders/{id}     # Slider sil

GET    /api/blogs            # Blog listesi
POST   /api/blogs            # Yeni blog
PUT    /api/blogs/{id}       # Blog güncelle
DELETE /api/blogs/{id}       # Blog sil

GET    /api/references       # Referans listesi
POST   /api/references       # Yeni referans
PUT    /api/references/{id}  # Referans güncelle
DELETE /api/references/{id}  # Referans sil

GET    /api/services         # Hizmet listesi
POST   /api/services         # Yeni hizmet
PUT    /api/services/{id}    # Hizmet güncelle
DELETE /api/services/{id}    # Hizmet sil

GET    /api/messages         # Mesaj listesi
POST   /api/messages         # Yeni mesaj (iletişim formu)
PUT    /api/messages/{id}    # Mesaj durumu güncelle
DELETE /api/messages/{id}    # Mesaj sil
```

## 📱 Responsive Tasarım

Her iki proje de tamamen responsive'dir:
- Desktop (1920px+)
- Laptop (1024px - 1919px)
- Tablet (768px - 1023px)
- Mobile (320px - 767px)

## 🚀 Production Deployment

### Web Sitesi (Next.js)
```bash
cd website
npm run build
npm start
# veya Vercel'e deploy
```

### Admin Paneli (React)
```bash
cd admin-panel
npm run build
# build/ klasörünü web sunucusuna yükle
```

## 📝 Özelleştirme

### Renkleri Değiştirmek
- **Web Sitesi**: `website/app/globals.css`
- **Admin Paneli**: `admin-panel/src/index.css`

### Logo ve Marka
- **Web Sitesi**: `website/components/Navbar.tsx`
- **Admin Paneli**: `admin-panel/src/components/Layout.tsx`

## 🛠️ Teknolojiler

### Web Sitesi
- Next.js 15
- React 19
- TypeScript
- Tailwind CSS
- CSS Animations

### Admin Paneli
- React 18
- TypeScript
- React Router DOM
- CSS3
- Axios (API istekleri için)

## 📞 Destek

Proje hakkında sorularınız için:
- E-posta: info@digitalmarketing.com
- Telefon: +90 (555) 123 45 67

## 📄 Lisans

Bu proje DigitalMarketing şirketi için özel olarak geliştirilmiştir.

---

**Geliştirici Notları:**
- Her iki proje de TypeScript ile yazılmıştır
- SEO için Next.js metadata API kullanılmıştır
- Admin panelinde authentication state localStorage'da tutulmaktadır
- Production'da güvenlik için JWT token kullanılmalıdır
- Tüm formlar validation'a hazırdır, backend entegrasyonu beklemektedir




