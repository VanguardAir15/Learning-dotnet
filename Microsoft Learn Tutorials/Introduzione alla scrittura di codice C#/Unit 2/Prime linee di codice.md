Riprendiamo il codice del esercizio precedente 
```
Console.WriteLine("Hello Word!");
```
e modifichiamolo precedendolo con //  in modo da commentarlo, 
// questo prefisso indica al compilatore di ignorare i commenti di quella riga.

I commenti di codice sono utili principalmente per 2 motivi
- Codice che 
	- non si ancora pronti ad eliminare completamente
	- si vuole ignorare al momento 
- Lasciare messaggi 
	- a se stessi per ricordare cosa fa il codice 
	- a altri utenti che stanno leggendo il codice 

ora il codice del esercizio precedente è cosi 
```
//Console.WriteLine("Hello Word!");
```

Ora aggiungiamoci nuove righe di codice per proseguire con l'esercizio 
```
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first line of code.");
```
se abbiamo fatto tutto correttamente vedremo nel output della console 
```
Congratulations! 

You wrote your first lines of code.
```

#### Ora vediamo le differenze dei 2 metodi di stampa che abbiamo usato nei 2 precedenti esercizi

i 2 metodi sono `Console.WriteLine();` e `Console.Write();`,
per primo abbiamo utilizzato `Console.WriteLine();` che oltre al messaggio `"Hello Word!"` che abbiamo inserito dentro alle parentesi alla fine ha inserito una nuova riga di testo simile a quando noi premiamo invio.
Invece il secondo che abbiamo utilizzato `Console.Write();` scrive tutto nella stessa riga.
