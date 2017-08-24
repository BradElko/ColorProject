function BeginGameLoad(){
    var colors = ["Red", "Orange", "Yellow", "Green", "Blue", "Purple"];
    var BottomLabel1 = document.getElementById("bl1");
    BottomLabel1.addEventListener("mousedown", BL1MD);
    function BL1MD(){
        var randomcolor = colors[Math.floor(Math.random()*colors.length)];
        BottomLabel1.style.color = randomcolor;
    }
}
function GameLoad(){
    var colors = ["Red", "Orange", "Yellow", "Green", "Blue", "Purple"];
    var randomcolor = colors[Math.floor(Math.random()*colors.length)];
    var LeftColorPanel2 = document.getElementById("lcp2");
    var TopLabel2 = document.getElementById("tl2");
    var RightLabel2 = document.getElementById("rl2");
    var clickedRightName = false;
    var clickedRightColor = false;
    var clickedRightNameColor = false;
    var clicks = 0;
    TopLabel2.addEventListener("mousedown", TL2MD);
    TopLabel2.addEventListener("mouseup", TL2MU);
    LeftColorPanel2.addEventListener("mouseup", LCP2MU);
    RightLabel2.addEventListener("mouseup", RL2MU);
    function TL2MD(){
        if(clickedRightName == true && clickedRightColor == true && clickedRightNameColor == true){
            TopLabel2.style.color = randomcolor;
        }
        else{
            TopLabel2.innerHTML = randomcolor;
        }
    }
    function TL2MU(){
        if(clickedRightName == true && clickedRightColor == true && clickedRightNameColor == true){
            clicks++;
            window.location.href = "EndGame.html";
        }       
    }
    function LCP2MU(){
        if(clickedRightColor == false && TopLabel2.innerHTML != "Click Here To Start"){
            var randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
            while (randomcolor2.toLowerCase() == LeftColorPanel2.style.backgroundColor){
                randomcolor2 = null;
                randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
                if(randomcolor2.toLowerCase() != LeftColorPanel2.style.color){
                    LeftColorPanel2.style.backgroundColorr = randomcolor2;
                    clicks++;
                    break;
                }
            }
            if(randomcolor2.toLowerCase() != LeftColorPanel2.style.backgroundColor){
                LeftColorPanel2.style.backgroundColor = randomcolor2;
                clicks++;
            }
            if (LeftColorPanel2.style.backgroundColor == randomcolor.toLowerCase()){
                clickedRightColor = true;
            } 
            randomcolor2 = null;
        }
    }
    function RL2MU(){
        if(clickedRightName == false && TopLabel2.innerHTML != "Click Here To Start"){
            var randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
            while (randomcolor2 == RightLabel2.innerHTML){
                randomcolor2 = null;
                randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
                if(randomcolor2 != RightLabel2.innerHTML){
                    RightLabel2.innerHTML = randomcolor2;
                    clicks++;
                    break;
                }
            }
            if(randomcolor2 != RightLabel2.color){
                RightLabel2.innerHTML = randomcolor2;
                clicks++;
            }
            if (RightLabel2.innerHTML == randomcolor){
                clickedRightName = true;
            }
            randomcolor2 = null;
        }
        else if(clickedRightName == true && clickedRightNameColor == false){
            var randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
            while (randomcolor2.toLowerCase() == RightLabel2.style.color){
                randomcolor2 = null;
                randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
                if(randomcolor2.toLowerCase() != RightLabel2.style.color){
                    RightLabel2.style.color = randomcolor2;
                    clicks++;
                    break;
                }
            }
            if(randomcolor2.toLowerCase() != RightLabel2.style.color){
                RightLabel2.style.color = randomcolor2;
                clicks++;
            }
            if (RightLabel2.style.color == randomcolor.toLowerCase()){
                clickedRightNameColor = true;
            }
            randomcolor2 = null;
        }
    }
}
function EndGameLoad(){
    var colors = ["Red", "Orange", "Yellow", "Green", "Blue", "Purple"];
    var BottomLabel3 = document.getElementById("bl3");
    BottomLabel3.addEventListener("mousedown", BL3MD);
    function BL3MD(){
        var randomcolor = colors[Math.floor(Math.random()*colors.length)];
        BottomLabel3.style.color = randomcolor;
    }
}