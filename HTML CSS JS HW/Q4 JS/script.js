function truncate(str, maxlength) {
       if (str.length > maxlength) {
                let temp = str.slice(0, maxlength - 1) + "...";
		return temp;
    	}else{
       	return str;
	}
}