function checkEmailId(str) {
    str = str.toLowerCase();
    let atPosition = str.indexOf('@');
    let dotPosition = str.indexOf('.', atPosition + 1);
    return atPosition > -1 && dotPosition > atPosition + 1;
}