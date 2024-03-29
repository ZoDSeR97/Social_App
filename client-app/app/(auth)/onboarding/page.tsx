﻿import { AccountProfile } from "@/components/forms/AccountProfile";
import { currentUser } from "@clerk/nextjs";
import { redirect } from "next/navigation";
import Cookies from "cookies";

export default async function Page() {
    const user = await currentUser();
    if (!user) return null;

    const userInfo = await fetch(`http://localhost:5030/api/User/${user.id}`);
    if (userInfo.ok) redirect("/");

    const userData = {
        id: user?.id || "",
        first_name: user?.firstName || "",
        last_name: user?.lastName || "",
        username: user?.username || user?.emailAddresses[0].emailAddress.split('@')[0] || "",
        email: user?.emailAddresses[0].emailAddress || "",
        bio: "",
        image: user?.imageUrl || ""
    };

    return (
        <main className="mx-auto flex max-w-3xl flex-col justify-start px-10 py-20">
            <h1 className="head-text">Profile</h1>
            <p className="mt-3 text-base-regular text-light-1">Completing profile information</p>
            <section className="mt-9 bg-dark-2 p-10">
                <AccountProfile user={ userData } btnTitle="Continue" />
            </section>
        </main>
    )
}