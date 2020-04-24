function addTrendingSong(sectionId, img, name){
    let trendingSec = document.getElementById('trending' + sectionId);
    let li = document.createElement('li');
    let sec = document.createElement('section');
    let h3 = document.createElement('h3');
    let p = document.createElement('p');
    let a = document.createElement('a');
    let i = document.createElement('i');

    sec.style.background = 'linear-gradient(black, transparent), url("' + img + '")';
    sec.style.backgroundSize = 'cover';
    sec.style.width = '200px';
    sec.style.height = '200px';
    
    h3.style.color = 'white';
    h3.style.fontSize = '14px';
    h3.style.paddingTop = '20px';
    h3.style.textAlign = 'center';

    p.style.color = 'white';
    p.style.fontSize = '60px';
    p.style.marginTop = '50px';
    p.style.textAlign = 'center';
    p.style.fontWeight = '0';

    h3.innerHTML = name;
    a.href = '#trending1';
    i.className = 'far fa-play-circle';

    li.appendChild(sec);
    sec.appendChild(h3);
    sec.appendChild(p);
    p.appendChild(a);
    a.appendChild(i);

    trendingSec.childNodes[3].appendChild(li);
}

addTrendingSong(1, 'res/images/augoeides-song.jpg', 'Dystopiaground – Augoeides');
addTrendingSong(1, 'res/images/baby-song.jpg', 'Justin Bieber - Baby ft. Ludacris');
addTrendingSong(1, 'res/images/fightinggold-song.jpg', 'Coda - Fighting Gold');
addTrendingSong(2, 'res/images/loseyourself-song.jpg', 'Eminem - Lose Yourself');
addTrendingSong(2, 'res/images/bsb-song.jpg', 'Backstreet Boys – I Want It That Way');
addTrendingSong(2, 'res/images/snowhalation-song.webp', 'μ’s - Snow Halation');

function Person(name, avatar){
    this.name = name;
    this.avatar = avatar;

    this.createReview = function (text){
        let articleStyle = `background-color: beige;
                            padding: 24px;
                            width: 300px;
                            border-radius: 16px;`
        let articleH3Style = `text-align: center;
                              font-size: larger;
                              margin: 8px;`
        let avatarStyle = `margin: auto;
                           width: 100px;
                           height: 100px;
                           border-radius: 60px;
                           display: block;`

        let art = document.createElement('section');
        let h3 = document.createElement('h3');
        let img = document.createElement('img');
        let q = document.createElement('q');

        art.style = articleStyle;
        h3.style = articleH3Style;
        img.style = avatarStyle;
        
        h3.innerText = this.name;
        img.src = this.avatar;
        q.innerText = text;

        art.appendChild(img);
        art.appendChild(h3);
        art.appendChild(q);

        return art;
    };

    this.addReview = function (text){
        let rev = document.getElementById('reviews');
        let li = document.createElement('li');
        li.appendChild(this.createReview(text));
        rev.lastChild.previousSibling.appendChild(li);
    };
}

let boris = new Person('Boris', 'res/images/snowhalation-song.webp');
let client = new Person('Client', 'res/images/baby-song.jpg');
let veska = new Person('Veska', 'res/images/bsb-song.jpg');

boris.addReview('Lorem, ipsum dolor sit amet consectetur adipisicing elit. Iure explicabo non provident reprehenderit tenetur laboriosam harum temporibus! Beatae magni ab id accusantium! Quae enim consectetur dolor fugiat, natus dicta at?');
client.addReview('Lorem ipsum dolor sit amet consectetur adipisicing elit. Sed itaque rem minus. Vel doloremque ipsam, atque sapiente voluptas deserunt veritatis ea quos similique corrupti modi, fuga nisi facilis, pariatur minus! Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ipsam dolores expedita officia eligendi ab nisi voluptatem aut cum, earum repellendus deleniti cupiditate quidem maiores vero commodi. Ullam natus magni esse?');
veska.addReview('Lorem, ipsum dolor sit amet consectetur adipisicing elit. Iure explicabo non provident reprehenderit tenetur laboriosam harum temporibus! Beatae magni ab id accusantium! Quae enim consectetur dolor fugiat, natus dicta at?');

let isBulbOn = false;
function lightOnOff(){
    let bulb = document.getElementById('themeChangeBulb');
    let chat = document.getElementById('chatButton');
    if(isBulbOn){
        // I know I can use document.body
        bulb.parentNode.parentNode.style.backgroundColor = '#252525';
        bulb.style.color = '#FFFFFF'
        chat.style.color = '#FFFFFF'
    }
    else{
        bulb.parentNode.parentNode.style.backgroundColor = '#b5b3ae';
        bulb.style.color = '#252525';
        chat.style.color = '#252525';
    }
    isBulbOn = !isBulbOn;
}