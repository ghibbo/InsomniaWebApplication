# InsomniaWebApplication

**Insomnia** è un REST client popolare e veloce compatibile con Mac, Windows e Linux. E' possibile utilizzare *insomnia* per testare le API RESTful e GraphQL. In questo semplice esempio mostriamo i benefici dello sviluppo rapido di API con Insomnia.

## Pre-Requisiti

- Visual Studio 2019
- .Net 5.0
- ASP.NET 5.0 Runtime
- Insomnia REST Client

## Vantaggi del test API: 

- Test anticipato
- Indipendente dalla GUI
- Indipendente dal linguaggio
- Copertura dei test migliorata
- Rilasci più veloci

## Start

Creare un applicazione minimalista ASP.NET Core  Web API 

### Classi e interfacce: 

- **Prodotto**: classe di entità per la memorizzazione dei dati del prodotto.
- **IProductRepository** : interfaccia per eseguire semplici operazioni CRUD sull'entità Prodotto.
- **ProductRepository**: gestisce l'interfaccia IProductRepository e implementa i suoi membri. 
- **ProductController**: classe del controller che contiene tutti i metodi di azione. 



## Test RESTful API in Insomnia

### Get Request:

1. Assicurarsi che l'applicazione API Web sia attiva e funzionante. 
2. Avviare il client REST *Insomnia*. 
3. Assicurati che il metodo HTTP GET sia selezionato (è il predefinito). 
4. Specificare l'URL nella barra degli indirizzi. 
5. Fare clic su Invia. 

![](/Resources/get-request.png)

### Post Request:

1. Specificare l'URL nella barra degli indirizzi. 
2. Specificare i dati JSON nel corpo della richiesta. 
3. Fare clic su Invia. 

![](/Resources/post-request.png)

## API GraphQL minimalista:

### Aggiunte le seguenti classi al progetto:

- ProductType
- ProductQuery
- GraphQLQueryDTO

### Schemas and Types:

Gli elementi costitutivi principali di GraphQL sono gli **schemi** e **tipi**. 

Uno schema estende la classe *GraphQL.Types.Schema* e rappresenta la funzionalità esposta tramite un endpoint per il client dell'API da consumare. 

Uno schema comprende Query, Mutation e Subscription. 

Query vengono utilizzate per consumare i dati in modo efficiente. 

Mutation sono utilizzati per inviare dati al server per eseguire operazioni CRUD. 

Subscription consentono di inviare i dati al client. 

### GraphQL Middleware:

GraphQL non è disponibile in ASP.NET Core di default.

> Install-Package GraphQL
> Install-Package GraphiQL

#### GraphQL Schema

Per essere in grado di interrogare i dati utilizzando GraphQL, creare un tipo che estenda ObjectGraphType<T> 

#### Query Type

Classe usata per il recupero dei dati. ProductQuery che estende ObjectGraphType. 

Quando si lavora con GraphQL, il client effettua sempre una chiamata HTTP POST e passa il nome della *query*, il nome dell'*operazione* e le *variabili*. Serve una classe POCO per gestire schema, variabili e argomento. 

#### Aggiunta del Services al Container

Metodo ConfigureServices.

#### Controller Class

Creare l' end-point GraphQL. 

Nuovo controller API chiamato DefaultController.

..........
