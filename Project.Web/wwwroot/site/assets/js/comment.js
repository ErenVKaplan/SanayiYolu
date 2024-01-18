function showPopup() {
    document.getElementById('replyPopup').style.display = 'block';
}
function closePopup() {
    document.getElementById('replyPopup').style.display = 'none';
}

// Function to submit the reply (you can customize this function)
function submitReply() {
    var replyText = document.getElementById('replyTextbox').value;
    // Add your logic to handle the submitted reply
    console.log('Submitted Reply:', replyText);
    // Close the popup after submission
    document.getElementById('replyPopup').style.display = 'none';
}

// Attach event listener to the reply link
document.getElementById('replyLink').addEventListener('click', function (event) {
    event.preventDefault(); // Prevent the default behavior of the link
    showPopup(); // Show the popup
});