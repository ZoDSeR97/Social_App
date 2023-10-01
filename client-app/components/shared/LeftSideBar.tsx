"use client"

import { navigationLinks } from "./NavigationLinks";
import Link from "next/link";
import Image from "next/image";
import { usePathname, useRouter } from "next/navigation";
import { SignedIn, SignOutButton } from "@clerk/nextjs";

export const LeftSideBar = () => {
    const router = useRouter();
    const path = usePathname();
    return (
        <section className="custom-scrollbar leftsidebar">
            <div className="flex w-full flex-1 flex-col gap-6 px-6">
                {navigationLinks.map((link) => {
                    const isActive = path.includes(link.route) && link.route.length > 1 || path === link.route;
                    return (
                        <Link href={link.route} key={link.label} className={`leftsidebar_link ${ isActive? "bg-primary-500":"" }` }>
                            <Image src={link.imgURL} alt={link.label} width={20} height={20} />
                            <p className="text-light-1 max-lg:hidden">
                                {link.label}
                            </p>
                        </Link>
                    )
                })
                }
            </div>
            <div className="mt-10 px-6">
                <SignedIn>
                    <SignOutButton signOutCallback={ () => router.push("/sign-in") }>
                        <Image src="/next.svg" alt="logout" width={20} height={20} />
                        <p className="text-light-1 max-lg:hidden">Logout</p>
                    </SignOutButton>
                </SignedIn>
            </div>
        </section>
    )
}