$(document).ready(function(){
    var books = [];

    $.ajax({
      type: "GET",
      url: "http://localhost:5020/api/books", // replace with your API endpoint
      dataType: "json",
      success: function(data) {
        books = data;
        console.log(books);
      },
      error: function(error) {
        console.log("Error: " + error);
      }
    });


    $('#search-bar').on('input', function() {
      const searchTerm = $(this).val().toLowerCase();
      const $dropdown = $('#search-dropdown');
      $dropdown.empty();
    
      books.forEach((book) => {
        if (book.author.toLowerCase().includes(searchTerm) || book.title.toLowerCase().includes(searchTerm)) {
          const $item = $(`
            <div>
              <img src="${book.imageUrl}">
              <p class="book-btn">${book.title}</p>
              <h5>by ${book.author}</h5>
            </div>
          `);
          $item.data('book', book);
          $dropdown.append($item);
        }
      });
    
      if ($dropdown.children().length > 0 && searchTerm.length != 0) {
        $dropdown.show();
      } else {
        $dropdown.hide();
      }
    });

    $(document).on("click", ".book-btn", function() {
      event.preventDefault();
      const buttonText = $(this).text();
      const matchingBook = books.find(book => book.title === buttonText);
      if (matchingBook) {
          $("#book-cover").find("img").attr("src", matchingBook.imageUrl);
          const firstLetter = matchingBook.title.charAt(0);
          const restOfTitle = matchingBook.title.slice(1);
          $("#book-cover").find("h2").html(`<span>${firstLetter}</span>${restOfTitle}`);
        $(".feature-text").find("p").html(`${matchingBook.description}`);
      } else {
        console.log("No match found!");
      }
    });

    
    $("#load-button").on("click", function() {
      let $subsection = $(this).next(".sub-section");
      if (!$subsection.length) {
        $subsection = $("<section>").addClass("sub-section");
        const $content = $("<div>").addClass("content");
        $subsection.append($content);
        $(this).after($subsection);
      }
      $subsection = $subsection.find(".content");
    
      const existingTitles = $subsection.find(".book-btn").map(function() {
        return $(this).text();
      }).get();
    
      books.forEach(element => {
        if (!existingTitles.includes(element.title)) {
          const $bookDiv = $("<div>").addClass("book-card");
          const $img = $("<img>").attr("src", element.imageUrl);
          const $title = $("<h3>").text(element.title).addClass("book-btn");
    
          $bookDiv.append($img).append($title);
          $subsection.append($bookDiv);
        }
      });
    });

      $('form').submit(function(event) {
        event.preventDefault();
        var formData = {
          'title': $('input[name="title"]').val(),
          'author': $('input[name="author"]').val(),
          'imageLink': $('input[name="image"]').val(),
          'review': $('textarea[name="description"]').val()
        };
    
        $.ajax({
          type: 'POST',
          url: 'http://localhost:5020/api/books',
          data: formData,
          dataType: 'json',
          success: function(data) {
            console.log('Book added successfully!');
          },
          error: function(xhr, status, error) {
            console.log('Error adding book: ' + error);
          }
        });
      });


    });