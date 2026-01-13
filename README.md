# Školení GitHub Copilot - Demo aplikace

Demonstrační ASP.NET Core REST API projekt pro školení GitHub Copilot s ukázkami využití AI asistovaného vývoje.

## Přehled

Tento projekt slouží jako praktická ukázka různých scénářů použití GitHub Copilot při vývoji webových aplikací. Obsahuje několik demo sekcí zaměřených na různé aspekty práce s Copilotem - od základních code completions přes chat až po pokročilý agent mode. Projekt je implementován jako REST API s využitím moderního .NET stacku.

## Klíčové vlastnosti

- **Demo01_Completions** - ukázky základních code completions
- **Demo02_NextEditSuggestions** - demonstrace návrhů dalších editací (ProductService)
- **Demo03_CopilotChat** - příklady využití Copilot chatu (DummyProductService, pomocné utility)
- **Demo04_AgentMode** - pokročilá práce s agent modem (Products a Subscriptions endpointy, OAS)
- **Demo05_VisualStudio2026** - ukázky specifické pro Visual Studio 2026
- REST API s Minimal APIs architekturou
- SQLite databáze s Entity Framework Core
- Integrace s Azure OpenAI

## Technologie a závislosti

- **.NET 9.0** - cílový framework
- **ASP.NET Core** - webový framework pro REST API
- **Entity Framework Core** - ORM pro práci s databází
- **SQLite** - databázový engine (Microsoft.EntityFrameworkCore.Sqlite 9.0.0)
- **Azure OpenAI** - integrace s AI službami (Azure.AI.OpenAI 2.1.0)
- **Minimal APIs** - architektura pro definici endpointů

## Požadavky (Prerequisites)

- .NET 9.0 SDK nebo novější
- Libovolné IDE s podporou .NET (Visual Studio 2022+, Visual Studio Code, JetBrains Rider)
- GitHub Copilot (pro využití demo ukázek)

Ověření verze .NET SDK:
```bash
dotnet --version
```

## Instalace a spuštění

### 1. Klonování repozitáře

```bash
git clone https://github.com/mirekholec/skoleni-copilot-inovio.git
cd skoleni-copilot-inovio
```

### 2. Obnovení závislostí

```bash
cd src
dotnet restore
```

### 3. Build projektu

```bash
dotnet build
```

### 4. Spuštění aplikace

Z kořenového adresáře repozitáře:
```bash
dotnet run --project src/Demo.csproj
```

Nebo z adresáře `src`:
```bash
dotnet run
```

Aplikace se spustí a bude dostupná na `https://localhost:[port]` (port je přidělen automaticky).

## Konfigurace

Aplikace používá standardní ASP.NET Core konfigurační systém. Hlavní konfigurační soubor je `src/appsettings.json`.

### Nastavení Azure OpenAI

Pro funkčnost AI funkcí je potřeba nakonfigurovat přístup k Azure OpenAI:

1. **Endpoint**: Nastaven v `appsettings.json` - `GptEndpoint`
2. **API klíč**: Z bezpečnostních důvodů se ukládá do User Secrets (necommituje se do repozitáře)

Konfigurace API klíče pomocí User Secrets:
```bash
cd src
dotnet user-secrets set "GptApiKey" "váš-api-klíč"
```

### Databáze

Projekt používá SQLite databázi (`demo.db`), která se vytvoří automaticky při prvním spuštění aplikace pomocí `DbInit` hosted service.

## Struktura projektu

```
src/
├── Data/                          # Datová vrstva (Entity Framework, modely)
├── Demo01_Completions/            # Demo: Code completions
├── Demo02_NextEditSuggestions/    # Demo: Next edit suggestions
├── Demo03_CopilotChat/            # Demo: Copilot chat
├── Demo04_AgentMode/              # Demo: Agent mode
│   ├── Products/                  # Products API endpointy
│   ├── Subscriptions/             # Subscriptions API endpointy
│   └── readme.md                  # Pokyny pro demo úkoly
├── Demo05_VisualStudio2026/       # Demo: Visual Studio 2026
├── wwwroot/                       # Statické soubory
├── Program.cs                     # Entry point aplikace
├── appsettings.json               # Konfigurace
└── Demo.csproj                    # Projektový soubor
```

## Další materiály

**Všechny ukázky jsou nově v [Notion](https://www.notion.so/miroslavholec/kolen-GPT-27e360b4e71080baacc5eb9f41208ffc?source=copy_link)** (veřejně nedostupné)

## Licence

MIT License - viz soubor [LICENSE](LICENSE) pro detaily.

Copyright (c) 2025 Miroslav Holec
