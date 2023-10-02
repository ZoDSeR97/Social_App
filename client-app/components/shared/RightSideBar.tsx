export const RightSideBar = () => {
    return (
        <section className="custom-scrollbar rightsidebar">
            <div className="flex w-full flex-1 flex-col gap-6 px-6 justify-start">
                <h4 className="head-text text-heading4-medium text-light-1">Something that interests user</h4>
            </div>
            <div className="flex w-full flex-1 flex-col gap-6 px-6 justify-start">
                <h4 className="head-text text-heading4-medium text-light-1">Suggested users</h4>
            </div>
        </section>
    )
}