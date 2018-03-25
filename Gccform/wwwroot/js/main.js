var hiddenClass = 'hidden';
var shownClass = 'toggled-from-hidden';

function petSectionHover() {
    var children = this.children;
    for(var i = 0; i < children.length; i++) {
        var child = children[i];
        if (child.className === hiddenClass) {
            child.className = shownClass;
        }
    }
}

function petSectionEndHover() {
    var children = this.children;
    for(var i = 0; i < children.length; i++) {
        var child = children[i];
        if (child.className === shownClass) {
            child.className = hiddenClass;
        }
    }
}

(function() {
    var petSections = document.getElementsByClassName('petname123');
    for(var i = 0; i < petSections.length; i++) {
        petSections[i].addEventListener('mouseover', petSectionHover);
        petSections[i].addEventListener('mouseout', petSectionEndHover);
    }
}())

$(function() {
    $( "#datepicker" ).datepicker({
        dateFormat : 'mm/dd/yy',
        changeMonth : true,
        changeYear : true,
        yearRange: '-100y:c+nn',
        maxDate: '-1d'
    });
});
$(function() {
    $( "#b1" ).datepicker({
        dateFormat : 'mm/dd/yy',
        changeMonth : true,
        changeYear : true,
        yearRange: '-100y:c+nn',
        maxDate: '-1d'
    });
});

$(function() {
    $( "#b2" ).datepicker({
        dateFormat : 'mm/dd/yy',
        changeMonth : true,
        changeYear : true,
        yearRange: '-100y:c+nn',
        maxDate: '-1d'
    });
});

