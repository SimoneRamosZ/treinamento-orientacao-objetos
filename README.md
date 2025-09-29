## Praticando Orientação a Objetos

### 1. Abstração

Abstração é quando você **esconde os detalhes complicados e mostra só o que é importante** para usar algo.

---

#### Um exemplo do dia a dia 🏠

Pense em um **controle remoto de TV**:

* Você não precisa saber como a TV funciona por dentro (os fios, circuitos, sinais de rádio).
* O que você vê são **botões**: ligar, aumentar volume, trocar de canal.
  
👉 Esses botões são a **abstração**: eles simplificam o uso e escondem os detalhes técnicos.

---

#### Um exemplo em programação 👩‍💻

Imagina que você tem uma função chamada:

```csharp
double Somar(double a, double b)
{
    return a + b;
}
```

Quando você chama `Somar(2, 3)`, não precisa se preocupar **como** a soma acontece dentro do computador (bits, registradores, processador).
Você só precisa saber: **“essa função recebe dois números e devolve a soma”**.

Isso é abstração.

---

## 2. Encapsulamento

Encapsulamento é quando você **coloca algo dentro de uma "caixa"** e controla como ele pode ser usado.
Assim você **protege os dados** e evita que outras partes do programa mexam neles de qualquer jeito.

---

### Exemplo do dia a dia 🚗

Pensa em um **carro**:

* Você consegue **dirigir**, acelerar, frear.
* Mas você **não tem acesso direto ao motor** enquanto dirige.
* O motor está **encapsulado** — protegido dentro do carro, e você interage com ele só pelos pedais e volante.

👉 Ou seja: você **controla como o motor é usado**, sem abrir o capô a cada vez que vai dirigir.

---

### Exemplo em programação 👩‍💻

Imagina uma classe de conta bancária:

```csharp
public class BankAccount
{
    private decimal balance; // campo privado (ninguém mexe direto)

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= balance)
            balance -= amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
```

* O **`balance`** está **privado** → ninguém de fora consegue mudar direto.
* Só dá pra mexer no saldo usando **métodos controlados** (`Deposit`, `Withdraw`).
* Isso protege contra erros, como alguém tentar colocar `balance = -1000`.

---

### 3. Herança

Herança é quando uma classe **aproveita** características de outra, como se fosse uma “família” no código.

👉 Uma classe **filha** herda atributos e comportamentos de uma classe **pai**.

---

### Exemplo do dia a dia 🐾

Pensa em **animais**:

* Todo **animal** respira, se alimenta e se movimenta.
* Mas cada tipo tem suas diferenças:

  * Cachorro: late 🐶
  * Gato: mia 🐱
  * Pássaro: voa 🐦

👉 Você não precisa repetir “respirar, se alimentar, se movimentar” em cada animal.
Eles **herdam** isso da classe geral **Animal**.

---

### Exemplo em programação 👩‍💻

```csharp
// Classe Pai
public class Animal
{
    public void Eat() => Console.WriteLine("The animal is eating");
    public void Sleep() => Console.WriteLine("The animal is sleeping");
}

// Classe Filha
public class Dog : Animal
{
    public void Bark() => Console.WriteLine("The dog is barking");
}

// Classe Filha
public class Cat : Animal
{
    public void Meow() => Console.WriteLine("The cat is meowing");
}
```

Uso:

```csharp
var dog = new Dog();
dog.Eat();   // herdado da classe Animal
dog.Bark();  // específico do Dog
```

O `Dog` não precisou reescrever o método `Eat()`, porque ele **herdou** da classe `Animal`.

---

### 4. Polimorfismo

Polimorfismo vem do grego: **poli = muitos, morfo = formas**.

👉 É a capacidade de um mesmo método ou ação ter **muitas formas de se comportar**, dependendo de quem está usando.

---

### Exemplo do dia a dia 🎹

Pensa no verbo **“falar”**:

* Uma **criança** fala de um jeito.
* Um **adulto** fala de outro.
* Um **papagaio** também “fala”, mas imita.

Todos executam a ação **“falar”**, mas **cada um do seu jeito**.
Isso é **polimorfismo**.

---

### Exemplo em programação 👩‍💻

```csharp
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows");
    }
}
```

Uso:

```csharp
Animal a1 = new Dog();
Animal a2 = new Cat();

a1.MakeSound(); // "The dog barks"
a2.MakeSound(); // "The cat meows"
```

👉 Veja:

* O método é sempre o mesmo (`MakeSound`).
* Mas o resultado muda conforme o **tipo real** do objeto (`Dog`, `Cat`).
