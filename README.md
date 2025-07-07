# 🌾 SelskiPazar.bg

<div align="center">
  <img src="https://via.placeholder.com/800x200/2d5a27/ffffff?text=SelskiPazar.bg" alt="SelskiPazar.bg Banner" width="800"/>
  
  **The Ultimate Bulgarian Rural Marketplace Platform**
  
  *Connecting local producers with conscious consumers across Bulgaria*
  
  [![Live Demo](https://img.shields.io/badge/🚀-Live%20Demo-2d5a27?style=for-the-badge)](https://selskipazar.bg)
  [![Documentation](https://img.shields.io/badge/📖-Documentation-2e7d32?style=for-the-badge)](https://docs.selskipazar.bg)
  [![Report Bug](https://img.shields.io/badge/🐛-Report%20Bug-ef4444?style=for-the-badge)](https://github.com/SimeonKovachev/selski-pazar-app/issues)
  [![Request Feature](https://img.shields.io/badge/💡-Request%20Feature-f57c00?style=for-the-badge)](https://github.com/SimeonKovachev/selski-pazar-app/issues)
</div>

---

## 🎯 About SelskiPazar.bg

SelskiPazar.bg is a revolutionary local marketplace platform specifically designed for rural Bulgaria. We bridge the gap between traditional village life and modern technology, enabling farmers, artisans, and service providers to connect directly with customers seeking authentic, locally-produced goods and services.

### 🌟 Core Mission

> **"Empowering Bulgarian rural communities through technology, preserving traditions while embracing innovation."**

- 🤝 **Direct Connections** - Eliminate middlemen, maximize profits for producers
- 🌱 **Sustainable Living** - Promote local consumption and reduce carbon footprint
- 🏘️ **Community Building** - Strengthen rural economies and preserve traditions
- 📱 **Digital Inclusion** - Make technology accessible to all generations

## ✨ Key Features

<table>
<tr>
<td width="50%">

### 🛒 Marketplace
- **Product Listings** - Fresh produce, dairy, honey, crafts
- **Service Directory** - Home repairs, farming, transport
- **Barter System** - Trade products without money
- **Help Requests** - Community assistance platform

### 🗺️ Location-Based
- **Interactive Map** - Visual discovery of nearby offerings
- **Radius Search** - Find products within 1-25km
- **Regional Filters** - Browse by municipality/region
- **GPS Integration** - Automatic location detection

</td>
<td width="50%">

### 💬 Communication
- **Real-time Chat** - Direct messaging system
- **Voice Messages** - Audio listings and communication
- **WhatsApp Integration** - Quick contact options
- **Call Buttons** - One-click phone calls

### 🔒 Trust & Safety
- **User Verification** - ID and phone verification
- **Review System** - 5-star ratings with comments
- **Photo Reviews** - Visual proof of quality
- **Moderation Tools** - Community guidelines enforcement

</td>
</tr>
</table>

## 🏗️ Architecture & Tech Stack

### 📱 Frontend (Next.js 14)
```typescript
Frontend Stack:
├── Next.js 14 (App Router)     // React framework with SSR/SSG
├── TypeScript 5.0              // Type safety and better DX
├── Tailwind CSS                // Utility-first styling
├── Framer Motion               // Smooth animations
├── React Hook Form             // Form management
├── React Query                 // Server state management
├── Zustand                     // Client state management
├── React Leaflet               // Interactive maps
└── PWA Support                 // Mobile app experience
```

### 🔧 Backend (.NET 8)
```csharp
Backend Architecture:
├── Clean Architecture          // Separation of concerns
├── .NET 8 Web API             // High-performance API
├── Entity Framework Core      // ORM with Code-First
├── PostgreSQL                 // Robust relational database
├── Redis                      // Caching and sessions
├── SignalR                    // Real-time communication
├── AutoMapper                 // Object-to-object mapping
├── FluentValidation          // Input validation
├── JWT Authentication        // Secure auth tokens
└── Swagger/OpenAPI           // API documentation
```

### 🗄️ Database & Services
```yaml
Infrastructure:
├── Supabase PostgreSQL        # Primary database
├── Supabase Auth              # User authentication
├── Supabase Storage           # File uploads
├── Supabase Realtime          # Live updates
├── Stripe                     # Payment processing
├── Twilio                     # SMS notifications
├── SendGrid                   # Email services
├── Cloudinary                 # Image optimization
└── Mapbox                     # Maps and geocoding
```

## 📁 Project Structure

```
selski-pazar-app/
├── 📱 frontend/                 # Next.js 14 Application
│   ├── src/
│   │   ├── app/                 # App Router pages
│   │   │   ├── (auth)/          # Authentication routes
│   │   │   ├── dashboard/       # User dashboard
│   │   │   ├── products/        # Product listings
│   │   │   ├── services/        # Service listings
│   │   │   ├── map/             # Interactive map
│   │   │   └── listing/[id]/    # Single listing view
│   │   ├── components/          # Reusable components
│   │   │   ├── ui/              # Base UI components
│   │   │   ├── forms/           # Form components
│   │   │   ├── layout/          # Layout components
│   │   │   └── listings/        # Listing components
│   │   ├── lib/                 # Utilities & configs
│   │   ├── hooks/               # Custom React hooks
│   │   └── styles/              # Global styles
│   └── public/                  # Static assets
│
├── 🔧 backend/                  # .NET 8 Web API
│   ├── src/
│   │   ├── Core/
│   │   │   ├── Domain/          # Domain entities & logic
│   │   │   └── Application/     # Use cases & DTOs
│   │   ├── Infrastructure/      # External concerns
│   │   │   ├── Persistence/     # Database & EF Core
│   │   │   ├── Services/        # External services
│   │   │   └── Identity/        # Authentication
│   │   └── Presentation/
│   │       └── API/             # Web API controllers
│   └── tests/                   # Unit & integration tests
│
├── 🔗 shared/                   # Shared TypeScript types
│   ├── types/                   # Interface definitions
│   ├── constants/               # App constants
│   └── utils/                   # Utility functions
│
├── 📚 docs/                     # Documentation
├── 🐳 infrastructure/           # Docker & deployment
├── 🛠️ scripts/                 # Automation scripts
└── 🧪 tools/                   # Development tools
```

## 🚀 Quick Start

### Prerequisites

- [Node.js 18+](https://nodejs.org/)
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/)

### Installation

```bash
# 1. Clone the repository
git clone https://github.com/SimeonKovachev/selski-pazar-app.git
cd selski-pazar-app

# 2. Run the setup script
chmod +x scripts/setup.sh
./scripts/setup.sh

# 3. Configure environment variables
cp frontend/.env.local.example frontend/.env.local
cp backend/appsettings.example.json backend/appsettings.Development.json

# 4. Start development servers
npm run dev
```

### Environment Configuration

<details>
<summary><strong>📱 Frontend Environment (.env.local)</strong></summary>

```bash
# Supabase Configuration
NEXT_PUBLIC_SUPABASE_URL=your_supabase_project_url
NEXT_PUBLIC_SUPABASE_ANON_KEY=your_supabase_anon_key

# API Configuration
NEXT_PUBLIC_API_URL=http://localhost:5000

# Map Configuration
NEXT_PUBLIC_MAPBOX_ACCESS_TOKEN=your_mapbox_token

# Analytics (Optional)
NEXT_PUBLIC_GA_MEASUREMENT_ID=your_google_analytics_id
```

</details>

<details>
<summary><strong>🔧 Backend Configuration (appsettings.Development.json)</strong></summary>

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=selskipazar_dev;Username=postgres;Password=your_password"
  },
  "JwtSettings": {
    "SecretKey": "your-super-secret-jwt-key-minimum-32-characters",
    "Issuer": "https://selskipazar.bg",
    "Audience": "https://selskipazar.bg",
    "ExpirationInMinutes": 60
  },
  "SupabaseSettings": {
    "Url": "your_supabase_project_url",
    "Key": "your_supabase_service_role_key"
  }
}
```

</details>

### Development URLs

- **Frontend**: http://localhost:3000
- **Backend API**: http://localhost:5000
- **API Documentation**: http://localhost:5000/swagger

## 📊 Database Schema

<details>
<summary><strong>Core Entities Overview</strong></summary>

```sql
-- Users table with comprehensive profile data
Users (
  Id, Email, FirstName, LastName, PhoneNumber,
  Location (Latitude, Longitude, City, Region),
  Role (Customer, Provider, Both, Admin),
  IsVerified, AverageRating, TotalReviews
)

-- Flexible listing system for products and services
Listings (
  Id, UserId, CategoryId, Title, Description,
  Type (Product, Service, Barter, HelpRequest),
  Price (Amount, Currency, Type, MaxAmount),
  Location, ImageUrls[], IsActive, ViewCount
)

-- Comprehensive order management
Orders (
  Id, CustomerId, ProviderId, ListingId,
  Status, PaymentStatus, TotalAmount,
  CommissionAmount, Notes, ScheduledAt
)

-- Rich review system with detailed ratings
Reviews (
  Id, OrderId, ReviewerId, RevieweeId,
  Rating, QualityRating, CommunicationRating,
  Comment, ImageUrls[], WouldRecommend
)

-- Real-time messaging system
Messages (
  Id, ConversationId, SenderId, ReceiverId,
  Content, MessageType, IsRead, SentAt
)
```

</details>

## 🎨 UI/UX Design System

### Color Palette
```css
/* Primary Colors - Inspired by Bulgarian nature */
--primary-green: #2d5a27    /* Deep village green */
--forest-green: #2e7d32     /* Forest green */
--nature-green: #7cb342     /* Spring green */

/* Accent Colors - Warm and trustworthy */
--accent-gold: #f57c00      /* Honey gold */
--accent-harvest: #ff8f00   /* Harvest yellow */
--accent-warm: #ffb74d      /* Warm orange */

/* Status Colors - Clear communication */
--success: #22c55e          /* Available/Success */
--warning: #f59e0b          /* Limited/Warning */
--danger: #ef4444           /* Error/Unavailable */
```

### Typography
- **Headings**: Poppins (800-900 weight) - Modern and bold
- **Body Text**: Inter (400-600 weight) - Excellent readability
- **Minimum Size**: 16px base for accessibility
- **Line Height**: 1.7-1.8 for comfortable reading

### Accessibility
- ✅ WCAG 2.1 AA compliant
- ✅ Minimum contrast ratio: 4.5:1
- ✅ Touch targets: Minimum 44px for mobile
- ✅ Keyboard navigation: Full support
- ✅ Screen reader: Semantic HTML + ARIA labels

## 🧪 Testing Strategy

```bash
# Run all tests
npm run test

# Frontend tests
cd frontend && npm test

# Backend tests  
cd backend && dotnet test

# E2E tests
npm run test:e2e
```

### Test Coverage
- **Unit Tests**: Core business logic
- **Integration Tests**: API endpoints
- **Component Tests**: React components
- **E2E Tests**: Critical user journeys

## 📈 Performance & Monitoring

### Frontend Optimization
- Next.js SSG/SSR for optimal loading
- Image Optimization via Next.js Image component
- Bundle Analysis with @next/bundle-analyzer
- Core Web Vitals monitoring

### Backend Performance
- Entity Framework optimizations
- Redis Caching for frequent queries
- API Response compression
- Database Indexing strategies

### Monitoring Tools
- Application Insights (Azure)
- Sentry for error tracking
- Google Analytics for user behavior
- Uptime Monitoring via StatusPage

## 🤝 Contributing

We welcome contributions from the Bulgarian tech community!

### Getting Started

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

### Development Guidelines

- Follow Clean Code principles
- Write comprehensive tests
- Use conventional commits
- Update documentation
- Ensure accessibility

### Code of Conduct
Be respectful, inclusive, and constructive. We're building something beautiful for Bulgaria! 🇧🇬

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE.txt) file for details.

## 🇧🇬 About Bulgaria

<div align="center">
  <strong>SelskiPazar.bg is proudly Made in Bulgaria 🇧🇬</strong>
  <br>
  <em>Dedicated to preserving Bulgarian rural traditions while embracing technological innovation</em>
  <br>
  <strong>За село, от село! (For the village, from the village!)</strong>
</div>

## 📞 Contact & Support

<div align="center">
  
[![Website](https://img.shields.io/badge/🌐-Website-2d5a27?style=for-the-badge)](https://selskipazar.bg)
[![Email](https://img.shields.io/badge/✉️-Email-2e7d32?style=for-the-badge)](mailto:info@selskipazar.bg)
[![LinkedIn](https://img.shields.io/badge/💼-LinkedIn-0077b5?style=for-the-badge)](https://linkedin.com/company/selskipazar)

**Built with ❤️ for Bulgarian rural communities**

</div>

---

<div align="center">
  
⭐ **Star this repository if you find it helpful!**

Help us spread the word about SelskiPazar.bg and support Bulgarian rural communities

[![GitHub stars](https://img.shields.io/github/stars/SimeonKovachev/selski-pazar-app?style=social)](https://github.com/SimeonKovachev/selski-pazar-app/stargazers)
[![GitHub forks](https://img.shields.io/github/forks/SimeonKovachev/selski-pazar-app?style=social)](https://github.com/SimeonKovachev/selski-pazar-app/network/members)

</div>
