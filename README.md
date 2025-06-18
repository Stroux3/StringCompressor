# StringCompressor

🚀 Простая библиотека для сжатия и восстановления строк в формате вида `a3b2c1` ⇄ `aaabbc`.  
Подходит для демонстрации архитектуры .NET-проекта с тестами, слоями и консольным приложением.

---

## 📦 Структура проекта

- `StringCompressor.Core` — библиотека с логикой сжатия и восстановления строк
- `StringCompressorApp` — консольное приложение с точкой входа (`Main`)
- `StringCompressor.Tests` — модульные тесты на xUnit

---

## 🧠 Функциональность

| Метод                     | Описание                                       |
|--------------------------|------------------------------------------------|
| `Compress(string)`       | Сжимает строку: `"aaabb"` → `"a3b2"`          |
| `DecompressWithRegex()`  | Восстанавливает строку с использованием Regex |
| `DecompressManual()`     | Восстанавливает строку вручную                |

---

## ▶️ Пример использования

```csharp
var compressor = new Compressor();

string input = "aaabbbbcc";
string compressed = compressor.Compress(input);           // a3b4c2
string restored = compressor.DecompressManual(compressed); // aaabbbbcc

Console.WriteLine(compressed);  // a3b4c2
Console.WriteLine(restored);    // aaabbbbcc
```

---

## 🧪 Тесты

Проект покрыт юнит-тестами с использованием [xUnit](https://xunit.net).  
Чтобы запустить тесты:

```bash
dotnet test
```

Проверяются:
- корректность сжатия и восстановления
- пустые строки
- одиночные символы
- симметрия `Compress → Decompress`

---

## 🛠️ Как запустить

1. Клонируй репозиторий:
   ```bash
   git clone https://github.com/Stroux3/StringCompressor.git
   cd StringCompressor
   ```

2. Построй решение:
   ```bash
   dotnet build
   ```

3. Запусти консольное приложение:
   ```bash
   dotnet run --project StringCompressorApp
   ```

4. Запусти тесты:
   ```bash
   dotnet test
   ```

---

## 🔧 Используемые технологии

- .NET 8
- C# 12
- xUnit (тестирование)
- Regex, StringBuilder
- Модульность: `Core`, `App`, `Tests`

---

## 📌 Планы на улучшение

- [ ] CI/CD через GitHub Actions
- [ ] BenchmarkDotNet для оценки скорости `Regex` vs `Manual`
- [ ] Публикация `Core`-библиотеки в NuGet
- [ ] Возможность работы с цифрами в строке (например, `"a12"`)

---

## 🧑‍💻 Автор

**Владимир (Stroux3)**  
📬 [GitHub Profile](https://github.com/Stroux3)
