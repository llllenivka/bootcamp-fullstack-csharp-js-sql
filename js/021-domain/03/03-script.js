const box = document.getElementById("box");
const animateBtn = document.getElementById("animateBtn");

animateBtn.addEventListener("click", function() 
{
    box.style.transition = "background-color 1s ease-in-out";
    box.style.backgroundColor = "blue";

    setTimeout(() => {
        box.style.transition = "width 1s ease-in-out, height 1s ease-in-out, rotate 1s ease-in-out";
        box.style.width = "200px";
        box.style.height = "200px";
        box.style.rotate = "15deg";
    }, 1000);
})