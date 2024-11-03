// Quản lý các mục bên trong sidebar
const allSideMenu = document.querySelectorAll('#sidebar .side-menu.top li a');
const menuBar = document.querySelector('#content nav .bx.bx-menu');
const sidebar = document.getElementById('sidebar');

// Thêm lớp 'active' cho mục đang chọn trong sidebar
allSideMenu.forEach(item => {
    const li = item.parentElement;

    item.addEventListener('click', function () {
        allSideMenu.forEach(i => {
            i.parentElement.classList.remove('active');
        });
        li.classList.add('active');
    });
});

// Ẩn/hiện sidebar khi nhấn vào biểu tượng menu
menuBar.addEventListener('click', function () {
    sidebar.classList.toggle('hide');
});

// Kiểm tra kích thước màn hình để ẩn sidebar nếu cần
if (window.innerWidth < 768) {
    sidebar.classList.add('hide');
}

// Điều chỉnh hiển thị sidebar khi thay đổi kích thước cửa sổ
window.addEventListener('resize', function () {
    if (this.innerWidth > 576) {
        sidebar.classList.remove('hide');
    }
});

// Chức năng chuyển đổi chế độ tối (switch mode)
const switchMode = document.getElementById('switch-mode');
if (localStorage.getItem('darkMode') === 'enabled') {
    document.body.classList.add('dark');
    switchMode.checked = true;
}

// Thay đổi chế độ sáng/tối khi nhấn vào switch
switchMode.addEventListener('change', function () {
    if (this.checked) {
        document.body.classList.add('dark');
        localStorage.setItem('darkMode', 'enabled');
    } else {
        document.body.classList.remove('dark');
        localStorage.setItem('darkMode', 'disabled');
    }
});

// Cập nhật lại giao diện khi nhấn vào tài khoản để hiện/ẩn menu tài khoản
const accountBtn = document.getElementById('account-btn');
const accountMenu = document.getElementById('account-menu');

accountBtn.addEventListener('click', () => {
    accountMenu.classList.toggle('show');
});

// Ẩn menu tài khoản khi nhấp ra ngoài khu vực menu
window.addEventListener('click', function(event) {
    if (!event.target.matches('#account-btn, #account-btn *')) {
        accountMenu.classList.remove('show');
    }
});

//toggle add
const addBtn = document.getElementById('addBtn');
const addModal = document.getElementById('addModal');
const closeModal = document.querySelector('.close');
const addForm = document.getElementById('addForm');
const boxInfoList = document.getElementById('boxInfoList');

addBtn.addEventListener('click', () => {
    addModal.style.display = 'block'; 
});

closeModal.addEventListener('click', () => {
    addModal.style.display = 'none'; 
});

window.addEventListener('click', (event) => {
    if (event.target == addModal) {
        addModal.style.display = 'none';
    }
});

//nút sửa xóa

// Biến để theo dõi mục hiện tại đang được sửa
let currentItemToEdit = null;

// Xử lý sự kiện khi nhấn nút Sửa và Xóa
document.addEventListener('click', function (event) {
    if (event.target.textContent === 'Xóa') {
        // Xóa mục
        const itemToDelete = event.target.closest('li');
        itemToDelete.remove();
    } else if (event.target.textContent === 'Sửa') {
        // Lưu mục hiện tại để sửa
        currentItemToEdit = event.target.closest('li');
        const name = currentItemToEdit.querySelector('h3').textContent;
        const info = currentItemToEdit.querySelector('p').textContent;

        // Hiển thị modal và đặt các giá trị vào các trường input
        addModal.style.display = 'block';
        document.getElementById('Name').value = name;
        document.getElementById('Info').value = info;
    }
});

// Cập nhật dữ liệu khi người dùng nhấn "Lưu"
addForm.addEventListener('submit', (event) => {
    event.preventDefault();

    if (currentItemToEdit) {
        // Cập nhật thông tin của mục đang sửa
        currentItemToEdit.querySelector('h3').textContent = document.getElementById('Name').value;
        currentItemToEdit.querySelector('p').textContent = document.getElementById('Info').value;

        // Đặt lại biến `currentItemToEdit` về `null` sau khi cập nhật
        currentItemToEdit = null;
    }

    // Đóng modal và đặt lại form
    addModal.style.display = 'none';
    addForm.reset();
});

document.addEventListener('DOMContentLoaded', function () {
    const editButtons = document.querySelectorAll('.editBtn');
    const editModal = document.getElementById('editModal');
    const editForm = document.getElementById('editForm');
    const editId = document.getElementById('editId');
    const editName = document.getElementById('editName');
    const editLocation = document.getElementById('editLocation');

    editButtons.forEach(button => {
        button.addEventListener('click', function () {
            const houseId = this.getAttribute('data-id');
            fetch(`/House/GetHouse/${houseId}`)
                .then(response => response.json())
                .then(data => {
                    editId.value = data.id;
                    editName.value = data.name;
                    editLocation.value = data.location;
                    editModal.style.display = 'block';
                });
        });
    });

    document.querySelectorAll('.close').forEach(span => {
        span.addEventListener('click', function () {
            editModal.style.display = 'none';
        });
    });
});



//Fan

$(document).ready(function() {
    let currentSpeed = 0.8; 

    // Xử lý sự kiện khi nhấn nút ON
    $(".on").click(function() {
        // Bắt đầu quay quạt với tốc độ hiện tại
        $(".box img").css({
            "animation": `rotateon ${currentSpeed}s infinite linear`
        });

        // Ẩn nút ON và hiển thị nút OFF
        $(".on").hide();
        $(".off").show();

        // Cập nhật bóng đổ cho nút ON và OFF
        $(".on").css("box-shadow", "0px 0px 20px 5px green");
        $(".off").css("box-shadow", "0px 0px 20px 5px red");
    });

    // Xử lý sự kiện khi nhấn nút OFF
    $(".off").click(function() {
        // Dừng quay quạt
        $(".box img").css({
            "animation": "none" // Dừng hiệu ứng quay
        });

        // Hiển thị nút ON và ẩn nút OFF
        $(".on").show();
        $(".off").hide();

        // Cập nhật bóng đổ cho nút ON và OFF
        $(".on").css("box-shadow", "0px 0px 20px 5px green");
        $(".off").css("box-shadow", "0px 0px 20px 5px red");
    });

    // Xử lý sự kiện khi nhấn vào các nút điều chỉnh tốc độ quạt
    $(".speed-button").click(function() {
        // Lấy tốc độ từ thuộc tính data-speed của nút
        currentSpeed = $(this).data("speed");

        // Kiểm tra nếu quạt đang quay (nút OFF đang hiển thị)
        if ($(".off").is(":visible")) {
            // Cập nhật tốc độ quay của quạt
            $(".box img").css({
                "animation": `rotateon ${currentSpeed}s infinite linear`
            });
        }
    });
});
