# 🔐 Authentication & Authorization Sistemi

Digital Agency projesine **JWT (JSON Web Token)** tabanlı authentication ve role-based authorization sistemi eklenmiştir.

---

## 📋 İçindekiler

1. [Eklenen Özellikler](#eklenen-özellikler)
2. [Migration & Database Setup](#migration--database-setup)
3. [API Endpoints](#api-endpoints)
4. [Kullanım Örnekleri](#kullanım-örnekleri)
5. [Swagger UI Kullanımı](#swagger-ui-kullanımı)
6. [Güvenlik Özellikleri](#güvenlik-özellikleri)
7. [Roller ve Yetkiler](#roller-ve-yetkiler)

---

## ✅ Eklenen Özellikler

### **Domain Katmanı**
- ✅ `User` Entity (Email, Password, FirstName, LastName, etc.)
- ✅ `Role` Entity (Admin, Editor, User)
- ✅ `UserRole` Entity (Many-to-many ilişkisi)
- ✅ `AuthenticationException` (401 Unauthorized)
- ✅ `ForbiddenException` (403 Forbidden)

### **Application Katmanı**
- ✅ `IAuthService`, `ITokenService`, `IPasswordHasher`, `ICurrentUserService` interfaces
- ✅ `LoginCommand` & Handler & Validator
- ✅ `RegisterCommand` & Handler & Validator
- ✅ `RefreshTokenCommand` & Handler
- ✅ JWT Settings configuration
- ✅ Auth DTOs (AuthResponseDto, LoginRequestDto, RegisterRequestDto)

### **Infrastructure Katmanı**
- ✅ `TokenService` - JWT token generation & validation
- ✅ `PasswordHasher` - PBKDF2 SHA256 güvenli password hashing
- ✅ `AuthService` - Login, Register, RefreshToken business logic
- ✅ `CurrentUserService` - HttpContext'ten kullanıcı bilgilerine erişim

### **Persistence Katmanı**
- ✅ `UserRepository`, `RoleRepository` implementations
- ✅ EF Core Configurations (UserConfiguration, RoleConfiguration, UserRoleConfiguration)
- ✅ Seed Data (3 default role: Admin, Editor, User)
- ✅ AppDbContext'e User/Role/UserRole DbSet'leri eklendi

### **WebApi Katmanı**
- ✅ JWT Authentication middleware
- ✅ Swagger JWT Authorization UI
- ✅ `AuthController` - Login, Register, RefreshToken endpoints
- ✅ Örnek authorization'lar (BlogsController'a role-based auth eklendi)
- ✅ Exception handling (AuthenticationException, ForbiddenException)

---

## 🗄️ Migration & Database Setup

### **1. Migration Oluştur**
```bash
cd src/Presentation/digitalAgency.WebApi
dotnet ef migrations add AddAuthenticationTables --project ../../Infrastructure/digitalAgency.Persistence
```

### **2. Database'i Güncelle**
```bash
dotnet ef database update --project ../../Infrastructure/digitalAgency.Persistence
```

### **3. Oluşturulacak Tablolar**
- `Users` - Kullanıcı bilgileri
- `Roles` - Rol tanımları (Seed data: Admin, Editor, User)
- `UserRoles` - User-Role many-to-many ilişkisi

---

## 🔌 API Endpoints

### **Authentication Endpoints**

#### **POST /api/auth/register**
Yeni kullanıcı kaydı

**Request:**
```json
{
  "email": "test@example.com",
  "password": "Test123",
  "confirmPassword": "Test123",
  "firstName": "Ali",
  "lastName": "Veli",
  "phoneNumber": "+905551234567"
}
```

**Response:**
```json
{
  "userId": "guid",
  "email": "test@example.com",
  "fullName": "Ali Veli",
  "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6...",
  "refreshToken": "base64_encoded_token",
  "accessTokenExpiration": "2024-11-22T10:00:00Z",
  "refreshTokenExpiration": "2024-11-29T09:00:00Z",
  "roles": ["User"]
}
```

#### **POST /api/auth/login**
Kullanıcı girişi

**Request:**
```json
{
  "email": "test@example.com",
  "password": "Test123"
}
```

**Response:** (Register ile aynı format)

#### **POST /api/auth/refresh-token**
Access token yenileme

**Request:**
```json
{
  "refreshToken": "your_refresh_token_here"
}
```

#### **GET /api/auth/me**
🔒 Requires Authentication

Şu anki kullanıcının bilgilerini döndürür.

#### **GET /api/auth/admin-only**
🔒 Requires Admin Role

Sadece Admin rolüne sahip kullanıcılar erişebilir.

---

## 📝 Kullanım Örnekleri

### **C# - HttpClient**

```csharp
// 1. Register
var registerRequest = new
{
    email = "test@example.com",
    password = "Test123",
    confirmPassword = "Test123",
    firstName = "Ali",
    lastName = "Veli"
};

var response = await httpClient.PostAsJsonAsync("api/auth/register", registerRequest);
var authResponse = await response.Content.ReadFromJsonAsync<AuthResponseDto>();

// 2. Access token'ı header'a ekle
httpClient.DefaultRequestHeaders.Authorization = 
    new AuthenticationHeaderValue("Bearer", authResponse.AccessToken);

// 3. Protected endpoint'e istek at
var blogsResponse = await httpClient.PostAsJsonAsync("api/blogs", newBlog);
```

### **JavaScript - Fetch API**

```javascript
// 1. Login
const loginResponse = await fetch('https://localhost:7263/api/auth/login', {
  method: 'POST',
  headers: { 'Content-Type': 'application/json' },
  body: JSON.stringify({
    email: 'test@example.com',
    password: 'Test123'
  })
});

const { accessToken, refreshToken } = await loginResponse.json();

// 2. Token'ı localStorage'a kaydet
localStorage.setItem('accessToken', accessToken);
localStorage.setItem('refreshToken', refreshToken);

// 3. Protected endpoint'e istek at
const blogsResponse = await fetch('https://localhost:7263/api/blogs', {
  method: 'POST',
  headers: {
    'Content-Type': 'application/json',
    'Authorization': `Bearer ${accessToken}`
  },
  body: JSON.stringify(newBlog)
});

// 4. Token expire olduğunda refresh et
if (blogsResponse.status === 401) {
  const refreshResponse = await fetch('https://localhost:7263/api/auth/refresh-token', {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify({ refreshToken })
  });
  
  const { accessToken: newToken } = await refreshResponse.json();
  localStorage.setItem('accessToken', newToken);
  
  // Retry the original request
  // ...
}
```

---

## 🎨 Swagger UI Kullanımı

1. **Uygulamayı Çalıştır**
   ```bash
   cd src/Presentation/digitalAgency.WebApi
   dotnet run
   ```

2. **Swagger UI'a Git**
   - URL: `https://localhost:7263/swagger`

3. **Login/Register Yap**
   - `/api/auth/register` endpoint'ini aç
   - "Try it out" butonuna tıkla
   - Kullanıcı bilgilerini gir ve "Execute"
   - Response'dan `accessToken`'ı kopyala

4. **Token'ı Swagger'a Ekle**
   - Sayfanın sağ üstündeki **"Authorize"** butonuna tıkla
   - Value: `Bearer {accessToken}` (Bearer kelimesi dahil)
   - "Authorize" butonuna tıkla

5. **Artık Protected Endpoint'leri Kullanabilirsin! 🎉**

---

## 🔒 Güvenlik Özellikleri

### **Password Security**
- ✅ **PBKDF2** ile 50,000 iterasyon
- ✅ **SHA256** hashing algorithm
- ✅ **Salt** - Her kullanıcı için unique salt
- ✅ **Minimum şifre gereksinimleri:**
  - En az 6 karakter
  - En az 1 büyük harf
  - En az 1 küçük harf
  - En az 1 rakam

### **JWT Token Security**
- ✅ **HMAC SHA256** signature
- ✅ Access token: 60 dakika (configurable)
- ✅ Refresh token: 7 gün (configurable)
- ✅ Token validation (Issuer, Audience, Lifetime)
- ✅ ClockSkew = 0 (Exact expiration)

### **Account Security**
- ✅ **Account Lockout** - 5 başarısız denemeden sonra 15 dakika kilitleme
- ✅ **Failed Login Tracking** - Başarısız giriş denemeleri kaydedilir
- ✅ **Email Uniqueness** - Her email sadece 1 kez kullanılabilir
- ✅ **IsActive Flag** - Hesap aktif/pasif kontrolü
- ✅ **Last Login Tracking** - Son giriş zamanı kaydedilir

---

## 👥 Roller ve Yetkiler

### **Varsayılan Roller** (Seed Data)

| Rol | Açıklama | Örnek Yetkiler |
|-----|----------|----------------|
| **Admin** | Sistem yöneticisi | Tüm CRUD işlemleri, kullanıcı yönetimi |
| **Editor** | İçerik editörü | Blog/Hizmet/Referans oluşturma & güncelleme |
| **User** | Normal kullanıcı | Sadece okuma yetkisi |

### **BlogsController Örnek Yetkilendirme**

```csharp
// Public - Herkes erişebilir
[HttpGet]
[AllowAnonymous]
public async Task<IActionResult> GetAll() { }

// Sadece Editor ve Admin
[HttpPost]
[Authorize(Roles = "Editor,Admin")]
public async Task<IActionResult> Create() { }

// Sadece Admin
[HttpDelete("{id}")]
[Authorize(Roles = "Admin")]
public async Task<IActionResult> Delete() { }
```

---

## 🚀 Sonraki Adımlar

### **Önerilen İyileştirmeler:**

1. ✅ **Email Confirmation**
   - Email doğrulama sistemi
   - Confirmation token generation

2. ✅ **Password Reset**
   - Şifremi unuttum özelliği
   - Reset token via email

3. ✅ **Two-Factor Authentication (2FA)**
   - SMS/Email OTP
   - Authenticator app support

4. ✅ **User Profile Management**
   - Profil güncelleme endpoints
   - Avatar upload

5. ✅ **Audit Logging**
   - Login history tracking
   - User action logs

6. ✅ **Rate Limiting**
   - Login endpoint rate limiting
   - DDoS protection

7. ✅ **Role Management API**
   - Admin paneli için rol yönetimi
   - Dynamic permission system

---

## 🧪 Test Senaryoları

### **1. Başarılı Register & Login**
```bash
# Register
curl -X POST https://localhost:7263/api/auth/register \
  -H "Content-Type: application/json" \
  -d '{
    "email": "test@example.com",
    "password": "Test123",
    "confirmPassword": "Test123",
    "firstName": "Test",
    "lastName": "User"
  }'

# Login
curl -X POST https://localhost:7263/api/auth/login \
  -H "Content-Type: application/json" \
  -d '{
    "email": "test@example.com",
    "password": "Test123"
  }'
```

### **2. Authorization Test**
```bash
# Token'sız istek - 401 Unauthorized
curl -X POST https://localhost:7263/api/blogs

# Token ile istek - Başarılı (Role kontrolü varsa rolüne göre)
curl -X POST https://localhost:7263/api/blogs \
  -H "Authorization: Bearer {your_token}" \
  -H "Content-Type: application/json" \
  -d '{ "title": "Test Blog", ... }'
```

### **3. Refresh Token**
```bash
curl -X POST https://localhost:7263/api/auth/refresh-token \
  -H "Content-Type: application/json" \
  -d '{ "refreshToken": "{your_refresh_token}" }'
```

---

## 📞 Destek

Sorularınız için:
- GitHub Issues
- Email: [your-email]

---

**🎉 Authentication sistemi başarıyla projeye entegre edildi!**

