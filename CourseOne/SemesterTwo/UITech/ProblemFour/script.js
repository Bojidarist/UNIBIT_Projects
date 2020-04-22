// 1 Strings

let textInput = document.getElementById('textInput');
let replaceInput = document.getElementById('replaceInput');
let stringText = document.getElementById('stringText');

function replaceExample(){
    let newText = stringText.innerText.replace(textInput.value, replaceInput.value)
    stringText.innerText = newText;
}

function toUpperExample(){
    stringText.innerText = stringText.innerText.toUpperCase();
}

function toLowerExample(){
    stringText.innerText = stringText.innerText.toLowerCase();
}

function inputText(){
    stringText.innerText = textInput.value;
}

// 2 Arrays

let arr = new Array();
let arrayInput = document.getElementById('arrayInput');
let itemList = document.getElementById('itemList');

function updateArrayVisually(){
    itemList.innerHTML = '';
    arr.forEach(el => {
        let item = document.createElement('li');
        item.innerText = el;
        itemList.appendChild(item);
    });
}

function addExample(){
    arr.push(arrayInput.value);
    updateArrayVisually();
}

function removeExample(){
    let i = arr.indexOf(arrayInput.value);
    if(arr[i]){
        arr.splice(i, 1);
    }
    updateArrayVisually();
}

function sortExample(){
    arr.sort();
    updateArrayVisually();
}