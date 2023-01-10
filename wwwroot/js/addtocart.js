const product = [
    {
        id: 0,
        image: 'https://cdn.shopify.com/s/files/1/0259/1427/7936/products/lemon-tart-puff-sleeve-detail-long-maxi-dress-ltamd498-yellow-29138011160624_540x.jpg?v=1637622815',
        title: 'Long Yellow Maxi',
        price: 5000,
    },
    {
        id: 1,
        image: 'https://cdn.shopify.com/s/files/1/0259/1427/7936/products/lemon-tart-color-block-detail-long-dress-ltamd190-28750062321712.jpg?v=1628243578',
        title: 'Zebra Print Frok',
        price: 6000,
    },
    {
        id: 2,
        image: 'https://cdn.shopify.com/s/files/1/0259/1427/7936/products/lemon-tart-women-s-lts525-kaftan-detail-stitched-kurti-and-pants-set-black-29878384754736_540x.jpg?v=1653000013',
        title: 'Shalwar Suit',
        price: 2300,
    },
    {
        id: 3,
        image: 'https://cdn.shopify.com/s/files/1/0259/1427/7936/products/lemon-tart-women-s-lts525-kaftan-detail-stitched-kurti-and-pants-set-black-29878384754736_540x.jpg?v=1653000013',
        title: 'Shalwar Suit',
        price: 2000,
    }
];
const categories = [...new Set(product.map((item)=>
    {return item}))]
    let i=0;
document.getElementById('root').innerHTML = categories.map((item)=>
{
    var {image, title, price} = item;
    return(
        `<div class='box'>
            <div class='img-box'>
                <img class='images' src=${image}></img>
            </div>
        <div class='bottom'>
        <p>${title}</p>
        <h2>$ ${price}.00</h2>`+
        "<button onclick='addtocart("+(i++)+")'>Add to cart</button>"+
        `</div>
        </div>`
    )
}).join('')

var cart =[];

function addtocart(a){
    cart.push({...categories[a]});
    displaycart();
}
function delElement(a){
    cart.splice(a, 1);
    displaycart();
}

function displaycart(){
    let j = 0, total=0;
    document.getElementById("count").innerHTML=cart.length;
    if(cart.length==0){
        document.getElementById('cartItem').innerHTML = "Your cart is empty";
        document.getElementById("total").innerHTML = "$ "+0+".00";
    }
    else{
        document.getElementById("cartItem").innerHTML = cart.map((items)=>
        {
            var {image, title, price} = items;
            total=total+price;
            document.getElementById("total").innerHTML = "$ "+total+".00";
            return(
                `<div class='cart-item'>
                <div class='row-img'>
                    <img class='rowimg' src=${image}>
                </div>
                <p style='font-size:12px;'>${title}</p>
                <h2 style='font-size: 15px;'>$ ${price}.00</h2>`+
                "<i class='fa-solid fa-trash' onclick='delElement("+ (j++) +")'></i></div>"
            );
        }).join('');
    }

    
}