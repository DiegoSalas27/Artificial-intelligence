var estadoInicial;
var end;
var items = new Array();

function Item(costo, peso){
    this.costo = costo
    this.peso = peso;
    this.sucesor = undefined;
}

function Mochila() {
    this.costo = 0;
    this.peso = 0;
}

function llenarItems(){
    items.push(new Item(8, 5));
    items.push(new Item(7, 6));
    items.push(new Item(6, 4));
    items.push(new Item(2, 1));
    items.push(new Item(3, 1));
}
function llenarMochila(){
    llenarItems();
    var mochila = new Mochila();
    var random = Math.floor((Math.random() * items.length-1) + 1);
    estadoInicial = items[random];
    var current = estadoInicial;
    mochila.push(estadoInicial);

    current.sucesor.push()
    while(mochila.peso <= 16){

    }
}

llenarMochila();
