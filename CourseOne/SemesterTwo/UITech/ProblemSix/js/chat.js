let infoBubble = document.getElementById("info-bubble");
let chatArea = document.getElementById('chat-area');
let chatInput = document.getElementById('chat-input');
let sendBtn = document.getElementById('chat-send-btn');
let deleteBtn = document.getElementById('chat-del-btn');
let replaceBtn = document.getElementById('chat-replace-btn');

let isOpen = false;
function openCloseChat(){
    if(isOpen){
        infoBubble.style.display = "none";
    }
    else{
        infoBubble.style.display = "block";
    }
    isOpen = !isOpen;
}

function sendMsg(){
    chatArea.insertBefore(document.createTextNode(chatInput.value + '\n'), chatArea.firstChild);
}

function deleteMsg(){
    if(chatArea.lastChild){
        chatArea.removeChild(chatArea.lastChild);
    }
}

function replaceMsg(){
    if(chatArea.firstChild){
        chatArea.replaceChild(document.createTextNode(chatInput.value + '\n'), chatArea.firstChild);
    }
}

chatArea.appendChild(document.createTextNode('Welcome to reverse chat!'));

sendBtn.onclick = sendMsg;
deleteBtn.onclick = deleteMsg;
replaceBtn.onclick = replaceMsg;