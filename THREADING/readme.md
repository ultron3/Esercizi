In questo esempio, creiamo due thread (thread1 e thread2) e ognuno di essi esegue un metodo diverso (Metodo1 e Metodo2). Utilizziamo il metodo Start() per avviare i thread, e successivamente utilizziamo Join() per attendere che entrambi i thread abbiano completato l'esecuzione prima di stampare un messaggio finale.

I due metodi Metodo1 e Metodo2 simulano un lavoro utilizzando Thread.Sleep() per aggiungere una breve pausa. Mentre Metodo1 fa pause di 100 millisecondi tra le iterazioni, Metodo2 fa pause di 150 millisecondi, dimostrando che i due thread eseguono operazioni in parallelo.