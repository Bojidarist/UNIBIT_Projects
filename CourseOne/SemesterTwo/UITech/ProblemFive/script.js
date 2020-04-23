let mdl = document.getElementById('cMdl');
let yr = document.getElementById('cDate');
let nitro = document.getElementById('cNitro');
let cmp = document.getElementById('cComp');
let prc = document.getElementById('cPrice');

function Car(model, year, hasNitro, company, price){
    this.model = model;
    this.year = year;
    this.hasNitro = hasNitro;
    this.company = company;
    this.price = price;
}

function addTextToOut(text){
    let c = document.createElement('p');
    c.innerHTML = text;
    document.getElementById('out').appendChild(c);
}

function displayCar(){
    document.getElementById('out').innerHTML = '';
    let car = new Car(
        model = mdl.value,
        year = yr.value,
        hasNitro = nitro.checked,
        company = cmp.options[cmp.selectedIndex].value,
        price = prc.value
    );

    addTextToOut('Model: ' + car.model);
    addTextToOut('Year: ' + car.year);
    addTextToOut('Nitro: ' + car.hasNitro);
    addTextToOut('Company: ' + car.company);
    addTextToOut('Price: ' + car.price);
}