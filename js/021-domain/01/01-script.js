function btnClick()
{
    textContainer.innerHTML = "<b><u>Новый текст</u></b>";
}

const changeTextBtn = document.getElementById("changeTextBtn");
const textContainer = document.getElementById("textContainer");

changeTextBtn.addEventListener("click", btnClick);