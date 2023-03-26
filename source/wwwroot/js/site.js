var modal = document.getElementById("myModal");
var modalBody = document.getElementById("modalBody");
var isModalOpen = 0;
window.onclick = function (event) {
  if (isModalOpen === 2 && event.target != modalBody) {
    closeModal();
  } else isModalOpen = 2;
}
function openModal(name, description) {
  if (isModalOpen === 0) {
    isModalOpen = 1;
    modal.style.display = "block";
    document.getElementsByTagName("body")[0].style.backgroundColor = "rgba(0, 0, 0, 0.7)";
    modalBody.innerHTML = `
      <h2>${name}</h2><br>
      <p>${description}</p>
    `;
  }
}
function closeModal() {
  modal.style.display = "none";
  isModalOpen = 0;
  document.getElementsByTagName("body")[0].style.backgroundColor = "";
}
