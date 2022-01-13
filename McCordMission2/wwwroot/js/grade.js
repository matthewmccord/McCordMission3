$("#Grade_Calc").click(function () {
    final_grade = ($("#assignments").val()) * 0.55 + ($("#quizzes").val()) * 0.10 + 
    ($("#group_project").val()) * 0.05 + ($("#exams").val()) * 0.20 + ($("#intex").val()) * 0.10
    if (final_grade >= 94) {
        letter_grade = 'A'
    }
    else if (final_grade >= 90) {
        letter_grade = 'A-'
    }
    else if (final_grade >= 87) {
        letter_grade = 'B+'
    }
    else if (final_grade >= 84) {
        letter_grade = 'B'
    }
    else if (final_grade >= 80) {
        letter_grade = 'B-'
    }
    else if (final_grade >= 77) {
        letter_grade = 'C+'
    }
    else if (final_grade >= 74) {
        letter_grade = 'C'
    }
    else if (final_grade >= 70) {
        letter_grade = 'C-'
    }
    else if (final_grade >= 67) {
        letter_grade = 'D+'
    }
    else if (final_grade >= 64) {
        letter_grade = 'D'
    }
    else if (final_grade >= 60) {
        letter_grade = 'D-'
    }
    else {
        letter_grade = 'E You Failed. Sorry :('
    }
    document.getElementById("Output").innerHTML = "Your grade is: " + letter_grade
})