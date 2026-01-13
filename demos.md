# Přehled demíček - Školení GitHub Copilot

Tento dokument obsahuje kompletní přehled všech ukázek v projektu školení GitHub Copilot.

## 📋 Obsah

1. [Demo01 - Completions](#demo01---completions)
2. [Demo02 - Next Edit Suggestions](#demo02---next-edit-suggestions)
3. [Demo03 - Copilot Chat](#demo03---copilot-chat)
4. [Demo04 - Agent Mode](#demo04---agent-mode)
5. [Demo05 - Visual Studio 2026](#demo05---visual-studio-2026)

---

## Demo01 - Completions

**Umístění:** `src/Demo01_Completions/`

**Účel:** Demonstrace základních automatických dokončování kódu (code completions) pomocí GitHub Copilot.

**Obsah:**
- `ProductDto.cs` - DTO třída pro produkty ze systému XY
  - Obsahuje základní validační atributy (`[Required]`, `[Range]`)
  - Demonstrační metoda `GetBasicInfo()` pro transformaci textu (odstranění diakritiky)

**Co se učí:**
- Základní usage Copilot completions při psaní kódu
- Automatické doplňování properties, metod a atributů
- Generování jednoduchých transformačních metod

---

## Demo02 - Next Edit Suggestions

**Umístění:** `src/Demo02_NextEditSuggestions/`

**Účel:** Ukázka funkcí "Next Edit" - navrhování dalších logických úprav kódu.

**Obsah:**
- `ProductService.cs` - Servisní třída pro práci s produkty
  - Metoda `Get(string category)` pro získání produktů dle kategorie
  - Připravená struktura pro rozšíření (komentář naznačuje další parametr `decimal priceFrom`)
  - Privátní metoda `GetInternal()` s dotazem do databáze přes Entity Framework Core

**Co se učí:**
- Copilot dokáže navrhovat další logické kroky v kódu
- Automatické dokončování LINQ dotazů
- Mapování entit na DTO objekty

---

## Demo03 - Copilot Chat

**Umístění:** `src/Demo03_CopilotChat/`

**Účel:** Demonstrace interakce s Copilot Chat pro vysvětlování a optimalizaci kódu.

**Obsah:**
- `DummyProductService.cs` - Minimální implementace product service (prázdná implementace)
- `RandomHelper.cs` - Záměrně nesrozumitelný kód pro generování náhodného řetězce
  - Metoda `GetString(int c)` s komentářem "Už nikdo neví, co tohle vlastně dělá"
  - Příležitost vyzkoušet funkce: Vysvětlit + Optimalizovat

**Co se učí:**
- Použití Copilot Chat pro vysvětlení nesrozumitelného kódu
- Optimalizace existujícího kódu pomocí AI asistence
- Refactoring legacy kódu s pomocí AI

---

## Demo04 - Agent Mode

**Umístění:** `src/Demo04_AgentMode/`

**Účel:** Ukázka práce s AI agenty pro generování komplexnějších struktur kódu (API endpointy).

**Obsah:**

### Struktura:
- `Endpoint.cs` - Hlavní registrace endpointů
- **Products/** - Adresář pro produktové endpointy
  - `ProductsEndpoint.cs` - REST API endpointy pro produkty
- **Subscriptions/** - Adresář pro subscription endpointy
  - `ISubscriptionService.cs` - Interface pro subscription službu
  - `SubscriptionDto.cs` - DTO pro subscription
  - `SubscriptionService.cs` - Implementace subscription služby
  - `SubscriptionsEndpoint.cs` - REST API endpointy pro subscriptions

### Úkoly (dle readme.md):
1. Vyladit endpoint Products, přidat GetById
2. Generovat to samé pro Subscriptions
3. Vytvořit requests.http file pro endpointy
4. Vygenerovat relevantní OAS soubor pro endpointy

**Co se učí:**
- Použití AI agentů pro generování rozsáhlejších kódových struktur
- Automatické vytváření REST API endpointů (Minimal APIs)
- Generování OpenAPI (OAS) specifikací
- Vytváření HTTP request souborů pro testování API

---

## Demo05 - Visual Studio 2026

**Umístění:** `src/Demo05_VisualStudio2026/`

**Účel:** Demonstrace pokročilých funkcí Visual Studio 2026 a debugging s Copilot.

**Obsah:**

### BrokenService.cs
- Třída se **záměrnou chybou** pro demonstraci debuggingu
- Metoda `GetCode()` generuje hexadecimální kód (10 znaků)
- **Chyba:** `rnd.Next(0, hexChars.Length + 1)` může způsobit IndexOutOfRangeException
- Implementuje logování (`ILogger`)

### Endpoint.cs
Obsahuje dva demonstrační endpointy:

1. **GET /broken** - Volá BrokenService pro demonstraci debuggingu
2. **GET /vs2026** - Obsahuje složitý podmíněný výraz pro vyhodnocení
   - Ukázka evaluace výrazů
   - Delegování vysvětlení na Copilota

**Co se učí:**
- Debugging s pomocí Copilot
- Identifikace a oprava runtime chyb
- Vysvětlování složitých podmíněných výrazů
- Využití logování pro debugging
- Práce s výrazy a jejich evaluace v novém Visual Studio

---

## 🚀 Jak spustit projekt

Projekt je ASP.NET Core Web API aplikace. Pro spuštění:

```bash
cd src
dotnet run
```

Endpointy:
- `/broken` - Demo05: BrokenService (debugging)
- `/vs2026` - Demo05: Vyhodnocení výrazů
- API endpointy z Demo04 (Products, Subscriptions)

## 📚 Další zdroje

Kompletní materiály ke školení jsou dostupné v [Notion](https://www.notion.so/miroslavholec/kolen-GPT-27e360b4e71080baacc5eb9f41208ffc) (veřejně nedostupné).

---

*Vytvořeno pro školení GitHub Copilot pro Inovio*
