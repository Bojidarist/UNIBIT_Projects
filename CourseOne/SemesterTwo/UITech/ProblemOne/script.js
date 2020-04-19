function createParagraph(text){
    let p = document.createElement('p');
    p.innerText = text;
    document.body.appendChild(p);
}

function getRandomColor() {
    var letters = '0123456789ABCDEF';
    var color = '#';
    for (var i = 0; i < 6; i++) {
        color += letters[Math.round(Math.random() * 16)];
    }
    return color;
}

function writeToHeaders(){
    let sentences = 
    [
        'As the rental car rolled to a stop on the dark road, her fear increased by the moment.',
        'She saw the brake lights, but not in time.',
        'No matter how beautiful the sunset, it saddened her knowing she was one day older.',
        'Truth in advertising and dinosaurs with skateboards have much in common.',
        'The sun had set and so had his dreams.'
    ]

    for (let i = 0; i < sentences.length; i++) {
        let s = sentences[i];
        let element = document.getElementById('header' + (i + 1).toString());
        element.innerText = s;
        element.style.color = getRandomColor();
    }
}

function clearHeaders(){
    for (let i = 1; i <= 5; i++) {
        document.getElementById('header' + i.toString()).innerText = '';
    }
}

let isHCleared = false;
function handleHeaders(){
    if(isHCleared){
        writeToHeaders();
    }
    else{
        clearHeaders();
    }
    isHCleared = !isHCleared;
}

// Create paragraphs
createParagraph('hello world');
createParagraph('She was not sure whether to be impressed or concerned that he folded underwear in neat little packages.');
createParagraph('She was sad to hear that fireflies are facing extinction due to artificial light, habitat loss, and pesticides.');
createParagraph('If eating three-egg omelets causes weight-gain, budgie eggs are a good substitute.');
createParagraph('I love bacon, beer, birds, and baboons.');

// Closing and opening the headers (does nothing except using precious cpu cycles ¯\_(ツ)_/¯ )
handleHeaders();
handleHeaders();