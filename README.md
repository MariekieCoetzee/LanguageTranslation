# 🌐 Blazor Multilingual Sample

A sample solution demonstrating **language translation in Blazor Server**, using `.resx` resource files and culture-aware middleware.  
WebAssembly support coming soon!

---

## 📁 Solution Structure

```plaintext
BlazorMultilingual.sln
│
├── BlazorServer/           # Blazor Server implementation
│   ├── Locals/             # Language resource files (e.g., .resx for en/af)
│   └── ...
│
├── BlazorWasm/             # WebAssembly version (planned)
│   ├── Locals/             # Language resources (to be added)
│   └── ...
│
└── README.md
```
## 🚀 Getting Started
Clone the repository:

```shell
git clone https://github.com/MariekieCoetzee/LanguageTranslation.git
cd LanguageTranslation
```
Run the Blazor Server project:

```shell
dotnet run --project BlazorServer
```

Navigate to https://localhost:7192
Use the dropdown to switch between English and Afrikaans.

## 🌍 Features
Culture-aware formatting (`CultureInfo.CurrentCulture`)

UI localisation via `.resx` files (`CultureInfo.CurrentUICulture`)

Language switching via `CultureController` and cookies

Language selection component

Separate `Locals/` folders per project

## 🧪 Current Projects
**BlazorServer**: Blazor Server sample with full localisation

**BlazorWasm**: (Coming soon) WebAssembly version

## 📚 Blog Post
📝 Read the blog – "[Blazor Server: Language Translation](https://medium.com/@mariekie/blazor-server-language-translation-1ead314db869)"