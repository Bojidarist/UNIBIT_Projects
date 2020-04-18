let infoBubble = document.getElementById("info-bubble");
let isOpen = false;

function openCloseInfo(){
    if(isOpen){
        infoBubble.style.display = "none";
    }
    else{
        infoBubble.style.display = "block";
    }
    isOpen = !isOpen;
}