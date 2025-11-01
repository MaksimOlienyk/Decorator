# Decorator — Патерн Проєктування

Патерн **Decorator** (Декоратор) дозволяє **динамічно додавати нову поведінку** об’єктам, **не змінюючи їхній клас**.  
Замість наслідування використовується **композиція** — ми «обгортаємо» об’єкт іншим.

---

## Ідея патерна

> Додати нові можливості об’єкту під час виконання, обгорнувши його у декоратор з додатковою поведінкою.

---

## Структура

| Роль | Опис |
|------|------|
| `IComponent` | Спільний інтерфейс для базового об’єкта та декораторів |
| `ConcreteComponent` | Базовий об’єкт |
| `Decorator` | «Обгортка», яка додає нову поведінку |

---

## Код

```csharp
interface IComponent { 
    void Operation(); 
}

class ConcreteComponent : IComponent { 
    public void Operation() => Console.WriteLine("Base operation"); 
}

class Decorator : IComponent {
    private IComponent _wrap;
    public Decorator(IComponent c) { _wrap = c; }

    public void Operation() {
        _wrap.Operation();
        Console.WriteLine(" + Decorated");
    }
}

class Program { 
    static void Main() => new Decorator(new ConcreteComponent()).Operation(); 
}
