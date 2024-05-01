in questo primo esercizio pratico useremo il C# per stampare una famosa frase dei programmatori nell' output standard di una console

Questo esercizio per tradizione è "Hello Word!" 
```
Console.Writeline("Hello Word!");
```

C# è un linguaggio Case Sensitive

Si verifica un messaggio di errore anche se scriviamo  
```
Console.WriteLine('Hello Word!');
```
con il seguente errore 
```
(1,19): error CS1012: Too many characters in character literal
```
in tutti i casi viene indicata la posizione del problema, fortunatamente gli errori non sono permanenti basterà solo trovarli , correggerlo e rieseguire il codice 

Se si è fatto un errore esaminare molto attentamente il codice, ogni singolo carattere. un IDE o editor di codice cercherà di aiutare aggiungendo linee rosse che evidenziano il codice che causerà un errore. gli errori più comuni sono

- L'uso di minuscole invece che maiuscole in 
	- la C inziale in Console
	- la W o la L inziale in WriteLine
- Mancato uso delle virgolette doppie o singole per chiudere la frase Hello Word!
- Mancato uso del punto e virgola alla fine del comando
