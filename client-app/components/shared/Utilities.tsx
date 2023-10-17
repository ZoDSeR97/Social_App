import {
    IoDuplicateOutline,
    IoEarthOutline,
    IoFitnessOutline,
    IoHomeOutline,
    IoLogOutOutline,
    IoPersonOutline,
    IoSearchOutline
} from "react-icons/io5";

export const navigationLinks = [
    {
        imgURL: "IoHomeOutline",
        route: "/",
        label: "Home",
    },
    {
        imgURL: "IoSearchOutline",
        route: "/search",
        label: "Search",
    },
    {
        imgURL: "IoFitnessOutline",
        route: "/activity",
        label: "Activity",
    },
    {
        imgURL: "IoDuplicateOutline",
        route: "/create-post",
        label: "Post",
    },
    {
        imgURL: "IoEarthOutline",
        route: "/communities",
        label: "Communities",
    },
    {
        imgURL: "IoPersonOutline",
        route: "/profile",
        label: "Profile",
    },
];

export const getIconComponent = (name: string) => {
    switch (name) {
        case "IoDuplicateOutline":
            return <IoDuplicateOutline/>;
        case "IoHomeOutline":
            return <IoHomeOutline/>;
        case "IoSearchOutline":
            return <IoSearchOutline/>;
        case "IoEarthOutline":
            return <IoEarthOutline/>
        case "IoPersonOutline":
            return <IoPersonOutline/>
        case "IoFitnessOutline":
            return <IoFitnessOutline />
        case "IoLogOutOutline":
            return <IoLogOutOutline/>
        default:
            return null;
    }
}

export const isBase64Image = (imageData: string) => {
    const base64Regex = /^data:image\/(png|jpe?g|gif|webp);base64,/;
    return base64Regex.test(imageData);
}