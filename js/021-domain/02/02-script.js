const addListBtn = document.getElementById("addListBtn");
const listContainer = document.getElementById("listContainer");

addListBtn.addEventListener("click", function()
{
    const listItem = document.createElement("li");
    listItem.textContent = "Новый элемент списка";
    listContainer.appendChild(listItem);
});