In questo esempio, stiamo utilizzando HttpClient per effettuare una richiesta HTTP GET asincrona a "https://www.example.com". Il metodo async ci consente di eseguire questa operazione in modo asincrono, in modo che il thread principale del programma non venga bloccato durante l'attesa della risposta HTTP. Abbiamo utilizzato await per attendere il completamento della richiesta e della lettura del contenuto della risposta in modo asincrono.

Questo è solo un esempio semplice di programmazione asincrona in C#. In applicazioni reali, l'uso di operazioni asincrone è molto comune per migliorare la reattività delle applicazioni e gestire operazioni lunghe come chiamate di rete, operazioni di I/O o altre attività intensive in termini di tempo.


# spiegazione metodo async e await

async è una parola chiave che viene utilizzata per dichiarare un metodo come asincrono. Quando dichiari un metodo come async, stai indicando che questo metodo può contenere operazioni asincrone. La firma del metodo includerà la parola chiave.


await è una parola chiave utilizzata all'interno di un metodo asincrono per attendere il completamento di un'operazione asincrona e ottenere il risultato. È seguito da un'espressione che rappresenta un'operazione asincrona. Quando si incontra un'istruzione await, il controllo viene restituito al chiamante, consentendo al thread principale di continuare l'esecuzione di altre attività, se disponibili. Quando l'operazione asincrona è completata, il controllo viene restituito al punto in cui è stato utilizzato await, e il risultato viene reso disponibile.