# 🔐 Frontend Authentication Integration Complete

Digital Agency projesinin hem **Admin Panel** (React/TypeScript) hem de **Website** (Next.js) frontend uygulamalarına JWT Authentication sistemi entegre edilmiştir.

---

## ✅ Yapılan Değişiklikler

### 🎨 **Admin Panel (React + TypeScript)**

#### **1. Auth Types & Interfaces**
📁 `src/types/auth.ts`
- User, LoginRequest, RegisterRequest interfaces
- AuthResponse, AuthContextType types

#### **2. Auth Service**
📁 `src/services/authService.ts`
- Login, Register, RefreshToken API calls
- Token storage (localStorage)
- Token expiration check
- Automatic logout on invalid token

#### **3. Auth Context & Provider**
📁 `src/context/AuthContext.tsx`
- Global authentication state management
- Auto-refresh expired tokens
- User info & roles management
- `useAuth()` custom hook

#### **4. Enhanced API Service**
📁 `src/services/api.ts`
- **Automatic token injection** in all API calls
- **401 Unauthorized** handling with token refresh
- **Retry logic** after token refresh
- Automatic redirect to login on auth failure

#### **5. Protected Route Component**
📁 `src/components/ProtectedRoute.tsx`
- Route protection based on authentication
- **Role-based access control** (RBAC)
- Loading state during auth check
- Access denied screen for insufficient permissions

#### **6. Login & Register Pages**
📁 `src/pages/Login.tsx`
📁 `src/pages/Register.tsx`
- Modern, responsive UI
- Form validation
- Error handling
- Loading states

#### **7. Updated Layout**
📁 `src/components/Layout.tsx`
- Display user info (name, initials, role)
- Logout functionality integrated
- No more dummy auth

#### **8. App Routing**
📁 `src/App.tsx`
- AuthProvider wraps entire app
- Public routes: `/login`, `/register`
- All other routes protected with ProtectedRoute
- Automatic redirect to dashboard after login

---

### 🌐 **Website (Next.js + TypeScript)**

#### **1. Auth API Functions**
📁 `lib/api/auth.ts`
- Complete auth API integration (login, register, refresh)
- SSR-safe (checks `typeof window !== 'undefined'`)
- Token management
- Helper functions (getAuthHeaders, isAuthenticated, etc.)

#### **2. Auth Context (Optional)**
📁 `lib/context/AuthContext.tsx`
- Client-side authentication state
- Use for user dashboard pages
- Same functionality as Admin Panel

---

## 🚀 Kurulum & Çalıştırma

### **Backend (API) Hazırlığı**

1. **Migration Çalıştır**
```bash
cd src/Presentation/digitalAgency.WebApi
dotnet ef migrations add AddAuthenticationTables --project ../../Infrastructure/digitalAgency.Persistence
dotnet ef database update --project ../../Infrastructure/digitalAgency.Persistence
```

2. **API'yi Başlat**
```bash
dotnet run
```
API çalışıyor: `https://localhost:7263`

---

### **Admin Panel Kurulum**

```bash
cd digital-agency-frontend/admin-panel

# Dependencies (eğer eksikse)
npm install

# Başlat
npm start
```

**URL:** `http://localhost:3000`

---

### **Website (Next.js) Kurulum**

```bash
cd digital-agency-frontend/website

# Dependencies (eğer eksikse)
npm install

# Development mode
npm run dev
```

**URL:** `http://localhost:3001` (veya mevcut port)

---

## 📖 Kullanım Kılavuzu

### **Admin Panel - İlk Kullanım**

#### **1. Kayıt Ol (Register)**

1. `http://localhost:3000/register` adresine git
2. Form doldur:
   ```
   Ad: Admin
   Soyad: User
   Email: admin@test.com
   Telefon: +90 555 123 4567 (opsiyonel)
   Şifre: Admin123
   Şifre Tekrar: Admin123
   ```
3. "Kayıt Ol" butonuna tıkla
4. **Otomatik olarak giriş yapılır ve Dashboard'a yönlendirilirsin**

#### **2. Giriş Yap (Login)**

1. `http://localhost:3000/login` adresine git
2. Email ve şifre gir
3. "Giriş Yap" butonuna tıkla
4. Dashboard'a yönlendirilirsin

#### **3. Protected Routes**

Artık tüm admin panel sayfaları korumalı:
- `/dashboard` ✅
- `/blogs` ✅ (Editor & Admin only)
- `/services` ✅
- `/references` ✅
- etc.

**Token olmadan** bu sayfalara erişmeye çalışırsan → `/login` sayfasına yönlendirilirsin.

---

## 🔒 Güvenlik Özellikleri

### **Admin Panel**

✅ **Token Storage:** localStorage (client-side only)
✅ **Automatic Token Refresh:** Access token expire olduğunda otomatik yenilenir
✅ **Retry Logic:** 401 hatası alındığında token refresh edip retry yapar
✅ **Protected Routes:** Authenticated olmayan kullanıcılar login'e yönlendirilir
✅ **Role-Based Access Control (RBAC):** Role gerektiren sayfalar var
✅ **Logout:** Token'lar temizlenir ve login'e yönlendirilir

### **API Interceptor Akışı**

```
1. API Request → Add Bearer Token to Header
                     ↓
2. Response 401? → Try Refresh Token
                     ↓ Success
3. Retry Original Request with New Token
                     ↓ Failure
4. Logout & Redirect to /login
```

---

## 🧪 Test Senaryoları

### **Senaryo 1: Yeni Kullanıcı Kaydı**

```bash
# 1. Register endpoint'e istek at
POST https://localhost:7263/api/auth/register
{
  "email": "test@example.com",
  "password": "Test123",
  "confirmPassword": "Test123",
  "firstName": "Test",
  "lastName": "User"
}

# 2. Response'da token ve user bilgisi gelir
# 3. Frontend otomatik olarak token'ı localStorage'a kaydeder
# 4. Dashboard'a yönlendirir
```

### **Senaryo 2: Login**

```bash
# Frontend: http://localhost:3000/login
# Email: test@example.com
# Password: Test123
# → Başarılı login → Dashboard
```

### **Senaryo 3: Protected API Call**

```javascript
// Örnek: Blog oluşturma (Editor/Admin only)
const response = await fetch('https://localhost:7263/api/blogs', {
  method: 'POST',
  headers: {
    'Authorization': `Bearer ${accessToken}`, // Otomatik eklenir
    'Content-Type': 'application/json'
  },
  body: JSON.stringify(newBlog)
});
```

### **Senaryo 4: Token Expiration**

```
1. Access token expire olur (60 dakika sonra)
2. API request yaparken 401 hatası alırsın
3. API service otomatik olarak refresh token kullanır
4. Yeni access token alır
5. Original request'i yeniden dener
6. Success! 🎉
```

### **Senaryo 5: Role-Based Access**

```typescript
// Sadece Admin'e özel sayfa
<ProtectedRoute requiredRole="Admin">
  <DeleteUserPage />
</ProtectedRoute>

// Editor veya Admin
<ProtectedRoute requiredRole="Editor">
  <CreateBlogPage />
</ProtectedRoute>
```

---

## 📝 Kod Örnekleri

### **useAuth Hook Kullanımı**

```typescript
import { useAuth } from '../context/AuthContext';

function MyComponent() {
  const { user, isAuthenticated, logout, hasRole } = useAuth();

  if (!isAuthenticated) {
    return <div>Lütfen giriş yapın</div>;
  }

  return (
    <div>
      <h1>Hoş geldin, {user?.fullName}!</h1>
      <p>Email: {user?.email}</p>
      <p>Roller: {user?.roles.join(', ')}</p>

      {hasRole('Admin') && (
        <button>Admin İşlemleri</button>
      )}

      <button onClick={logout}>Çıkış Yap</button>
    </div>
  );
}
```

### **API Service Kullanımı**

```typescript
import { api } from '../services/api';

// Token otomatik olarak eklenir!
const blogs = await api.get('/api/blogs');
const newBlog = await api.post('/api/blogs', blogData);
await api.put(`/api/blogs/${id}`, updatedData);
await api.delete(`/api/blogs/${id}`);
```

### **Protected Route**

```typescript
import ProtectedRoute from './components/ProtectedRoute';

// Sadece authenticated users
<ProtectedRoute>
  <Dashboard />
</ProtectedRoute>

// Sadece Admin
<ProtectedRoute requiredRole="Admin">
  <AdminPanel />
</ProtectedRoute>
```

---

## 🎯 Roller ve Yetkiler

| Rol | Admin Panel Access | Blog Create/Edit | Blog Delete | User Management |
|-----|-------------------|------------------|-------------|-----------------|
| **User** | ❌ | ❌ | ❌ | ❌ |
| **Editor** | ✅ | ✅ | ❌ | ❌ |
| **Admin** | ✅ | ✅ | ✅ | ✅ |

---

## 🐛 Troubleshooting

### **Problem: Token'lar kaydedilmiyor**
**Çözüm:** Browser console'da `localStorage.getItem('accessToken')` kontrol et. CORS ayarlarını kontrol et.

### **Problem: Login sonrası hala login sayfasındayım**
**Çözüm:** Network tab'dan API response'u kontrol et. Token geldi mi? localStorage'a kaydedildi mi?

### **Problem: 401 Unauthorized hatası**
**Çözüm:** 
1. Token expire olmuş olabilir → Refresh çalışıyor mu?
2. Backend'de JWT settings doğru mu?
3. Token format'ı: `Bearer {token}` olmalı

### **Problem: CORS hatası**
**Çözüm:** Backend `Program.cs` CORS ayarlarını kontrol et:
```csharp
options.AddPolicy("AllowFrontend", policy =>
{
    policy.WithOrigins("http://localhost:3000")
          .AllowAnyHeader()
          .AllowAnyMethod()
          .AllowCredentials();
});
```

---

## 🚀 Production Checklist

### **Backend**
- [ ] JWT SecretKey'i environment variable'dan al
- [ ] HTTPS zorunlu yap (RequireHttpsMetadata = true)
- [ ] CORS policy'yi production URL'e güncelle
- [ ] Rate limiting ekle (login endpoint)
- [ ] Email confirmation sistemi (opsiyonel)
- [ ] 2FA (opsiyonel)

### **Frontend - Admin Panel**
- [ ] API_BASE_URL environment variable'a taşı
- [ ] Error tracking (Sentry, etc.)
- [ ] Session timeout warning
- [ ] Remember me functionality
- [ ] Password reset sayfası

### **Frontend - Website**
- [ ] User dashboard sayfaları (eğer gerekiyorsa)
- [ ] Profile edit sayfası
- [ ] SSR/SSG auth handling

---

## 📞 Destek

Sorun yaşarsan:
1. Browser console log'larını kontrol et
2. Network tab'dan API response'ları incele
3. Backend Swagger UI'dan API'yi test et
4. localStorage token'larını kontrol et

---

## 🎉 Tebrikler!

Frontend'inizde artık **production-ready authentication sistemi** var! 🚀

**Sonraki Adımlar:**
- Password reset functionality
- Email confirmation
- 2FA
- Social login (Google, GitHub)
- Remember me
- Session management

---

**Not:** Bu entegrasyon **best practices** kullanılarak yapılmıştır:
- ✅ Token refresh mechanism
- ✅ Automatic retry on 401
- ✅ Protected routes
- ✅ Role-based access control
- ✅ Secure token storage
- ✅ Clean separation of concerns


